using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Data;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace WinForms
{
    public static class ReporteRecepcion
    {
        public static void Generar(string filePath)
        {
            // Asegúrate de usar la licencia adecuada una sola vez (se puede hacer también en Program.Main)
            QuestPDF.Settings.License = LicenseType.Community;

            var turnoRepository = new TurnoRepository();
            var turnos = turnoRepository.GetAll().ToList();

            int totalTurnos = turnos.Count(t => t.Estado == "Reservado");
            int turnosConMail = turnos.Count(t => t.RecibeMail && t.Estado == "Reservado");
            int turnosSinMail = totalTurnos - turnosConMail;
            int turnosConObservaciones = turnos.Count(t => !string.IsNullOrWhiteSpace(t.Observaciones) && t.Estado == "Reservado");
            int turnosSinObservaciones = totalTurnos - turnosConObservaciones;

            var graficoRecibeMail = GenerarGraficoCircular(turnosConMail, turnosSinMail);
            var graficoObservaciones = GenerarGraficoBarras(turnosConObservaciones, turnosSinObservaciones);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Arial"));

                    page.Header()
                        .Column(col =>
                        {
                            col.Item()
                            .AlignCenter()
                            .Text("REPORTE DE RECEPCIÓN")
                            .FontSize(20)
                            .Bold();

                            col.Item()
                                .AlignCenter()
                                .Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}")
                                .FontSize(9);
                        });

                    page.Content()
                        .Column(col =>
                        {
                            col.Spacing(20);

                            col.Item().Background(Colors.Grey.Lighten3).Padding(10)
                            .Row(row =>
                            {
                                row.RelativeItem().Text($"Total de turnos: {totalTurnos}").SemiBold();
                                row.RelativeItem().AlignRight().Text($"Fecha: {DateTime.Now:dd/MM/yyyy}");
                            });

                            col.Item().Column(x =>
                            {
                                x.Item().Text("Preferencia de recepción de mails").FontSize(14).Bold().FontColor(Colors.Blue.Medium);
                                x.Item().Image(ConvertirImagenABytes(graficoRecibeMail));
                                x.Item().AlignCenter().Text($"Con mail: {turnosConMail}  |  Sin mail: {turnosSinMail}");
                            });

                            col.Item().Column(x =>
                            {
                                x.Item().PaddingTop(15).Text("Turnos con observaciones").FontSize(14).Bold().FontColor(Colors.Blue.Medium);
                                x.Item().Image(ConvertirImagenABytes(graficoObservaciones));
                                x.Item().AlignCenter().Text($"Con observaciones: {turnosConObservaciones}  |  Sin observaciones: {turnosSinObservaciones}");
                            });
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                            x.Span(" de ");
                            x.TotalPages();
                        });
                });
            })
            .GeneratePdf(filePath);
            graficoRecibeMail.Dispose();
            graficoObservaciones.Dispose();
        }

        private static System.Drawing.Image GenerarGraficoCircular(int conMail, int sinMail)
        {
            int width = 300, height = 200;
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(System.Drawing.Color.White);

                int total = conMail + sinMail;
                if (total == 0) total = 1;

                float anguloConMail = (float)conMail / total * 360;
                float anguloSinMail = (float)sinMail / total * 360;

                Rectangle rect = new Rectangle(20, 20, 160, 160);
                Brush azul = new SolidBrush(System.Drawing.Color.FromArgb(60, 120, 216));
                Brush gris = new SolidBrush(System.Drawing.Color.FromArgb(200, 200, 200));

                g.FillPie(azul, rect, 0, anguloConMail);
                g.FillPie(gris, rect, anguloConMail, anguloSinMail);

                g.DrawString("Con Mail", new Font("Arial", 9), azul, 200, 70);
                g.DrawString($"{(conMail * 100f / total):0.0}%", new Font("Arial", 8), Brushes.Black, 260, 70);

                g.DrawString("Sin Mail", new Font("Arial", 9), gris, 200, 90);
                g.DrawString($"{(sinMail * 100f / total):0.0}%", new Font("Arial", 8), Brushes.Black, 260, 90);
            }
            return bmp;
        }

        private static System.Drawing.Image GenerarGraficoBarras(int conObs, int sinObs)
        {
            int width = 300, height = 200;
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(System.Drawing.Color.White);

                int max = Math.Max(conObs, sinObs);
                if (max == 0) max = 1;

                float escala = 120f / max;

                Brush verde = new SolidBrush(System.Drawing.Color.FromArgb(100, 180, 100));
                Brush gris = new SolidBrush(System.Drawing.Color.FromArgb(180, 180, 180));

                g.FillRectangle(verde, 60, 150 - conObs * escala, 50, conObs * escala);
                g.FillRectangle(gris, 160, 150 - sinObs * escala, 50, sinObs * escala);

                g.DrawString("Con Obs", new Font("Arial", 9), Brushes.Black, 60, 160);
                g.DrawString("Sin Obs", new Font("Arial", 9), Brushes.Black, 160, 160);

                g.DrawString($"{conObs}", new Font("Arial", 8), Brushes.Black, 70, 130 - conObs * escala);
                g.DrawString($"{sinObs}", new Font("Arial", 8), Brushes.Black, 170, 130 - sinObs * escala);
            }
            return bmp;
        }

        private static byte[] ConvertirImagenABytes(System.Drawing.Image imagen)
        {
            using (var ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

    }
}