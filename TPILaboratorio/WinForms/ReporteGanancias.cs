using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using API.Clients;
using Data;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace WinForms
{
    public static class ReporteGanancias
    {
        public async static void Generar(string filePath)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var turnos = await TurnoApiClient.GetAllAsync();

            var filas = new List<(int Id, DateTime Fecha, string Paciente, string TipoNombre, double Importe)>();
            double total = 0;

            foreach (var t in turnos)
            {
                var tipo = t.IdTipoAnalisis != 0 ? await TipoAnalisisApiClient.GetAsync(t.IdTipoAnalisis) : null;
                var paciente = t.IdPaciente != 0 ? await PacienteApiClient.GetAsync(t.IdPaciente) : null;

                double importe = tipo?.Importe ?? 0.0;
                string pacienteNombre = paciente != null
                    ? $"{paciente.Nombre} {paciente.Apellido}"
                    : (t.IdPaciente != 0 ? t.IdPaciente.ToString() : "-");
                string tipoNombre = tipo?.Nombre ?? "-";

                filas.Add((t.Id, t.FechaHoraReserva, pacienteNombre, tipoNombre, importe));
                total += importe;
            }

            var culture = new CultureInfo("es-AR");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial"));

                    // ENCABEZADO
                    page.Header()
                        .PaddingBottom(10)
                        .Column(col =>
                        {
                            col.Item()
                                .AlignCenter()
                                .Text("REPORTE DE GANANCIAS")
                                .FontSize(20)
                                .Bold()
                                .FontColor(Colors.Blue.Darken2);

                            col.Item()
                                .PaddingTop(5)
                                .AlignCenter()
                                .Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}")
                                .FontSize(9)
                                .FontColor(Colors.Grey.Darken1);

                            col.Item()
                                .PaddingTop(10)
                                .LineHorizontal(2)
                                .LineColor(Colors.Blue.Medium);
                        });

                    // CONTENIDO
                    page.Content()
                        .PaddingVertical(10)
                        .Column(x =>
                        {
                            // Info general
                            x.Item()
                                .Background(Colors.Grey.Lighten3)
                                .Padding(8)
                                .Row(row =>
                                {
                                    row.RelativeItem()
                                        .Text($"Total de turnos: {filas.Count}")
                                        .FontSize(10)
                                        .SemiBold();

                                    row.RelativeItem()
                                        .AlignRight()
                                        .Text($"Importe total: {total.ToString("C2", culture)}")
                                        .FontSize(10)
                                        .SemiBold()
                                        .FontColor(Colors.Green.Darken2);
                                });

                            x.Item().PaddingTop(15);

                            // TABLA
                            x.Item().Table(table =>
                            {
                                // Definición de columnas más equilibrada
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(50);      // ID
                                    columns.RelativeColumn(3);        // Paciente
                                    columns.RelativeColumn(2.5f);    // Tipo Análisis
                                    columns.ConstantColumn(105);     // Fecha
                                    columns.ConstantColumn(85);      // Importe
                                });

                                // ENCABEZADO DE TABLA
                                table.Header(header =>
                                {
                                    header.Cell().Element(CellHeaderStyle).AlignCenter().Text("ID").Bold();
                                    header.Cell().Element(CellHeaderStyle).Text("Paciente").Bold();
                                    header.Cell().Element(CellHeaderStyle).Text("Tipo de Análisis").Bold();
                                    header.Cell().Element(CellHeaderStyle).AlignCenter().Text("Fecha Reserva").Bold();
                                    header.Cell().Element(CellHeaderStyle).AlignRight().Text("Importe").Bold();
                                });

                                // FILAS DE DATOS
                                bool isAlternate = false;
                                foreach (var f in filas)
                                {
                                    var bgColor = isAlternate ? Colors.Grey.Lighten4 : Colors.White;

                                    table.Cell().Element(c => CellDataStyle(c, bgColor))
                                        .AlignCenter()
                                        .Text(f.Id.ToString());

                                    table.Cell().Element(c => CellDataStyle(c, bgColor))
                                        .Text(f.Paciente);

                                    table.Cell().Element(c => CellDataStyle(c, bgColor))
                                        .Text(f.TipoNombre);

                                    table.Cell().Element(c => CellDataStyle(c, bgColor))
                                        .AlignCenter()
                                        .Text(f.Fecha == default ? "-" : f.Fecha.ToString("dd/MM/yyyy HH:mm"));

                                    table.Cell().Element(c => CellDataStyle(c, bgColor))
                                        .AlignRight()
                                        .Text(f.Importe.ToString("C2", culture))
                                        .FontColor(Colors.Green.Darken1);

                                    isAlternate = !isAlternate;
                                }
                            });

                            // TOTAL FINAL
                            x.Item()
                                .PaddingTop(15)
                                .Column(col =>
                                {
                                    col.Item()
                                        .LineHorizontal(2)
                                        .LineColor(Colors.Blue.Medium);

                                    col.Item()
                                        .PaddingTop(10)
                                        .AlignRight()
                                        .Background(Colors.Blue.Lighten4)
                                        .Padding(10)
                                        .Text(text =>
                                        {
                                            text.Span("TOTAL GENERAL: ").Bold().FontSize(13);
                                            text.Span(total.ToString("C2", culture))
                                                .Bold()
                                                .FontSize(14)
                                                .FontColor(Colors.Green.Darken2);
                                        });
                                });
                        });

                    // PIE DE PÁGINA
                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Página ").FontSize(9).FontColor(Colors.Grey.Medium);
                            x.CurrentPageNumber().FontSize(9).FontColor(Colors.Grey.Medium);
                            x.Span(" de ").FontSize(9).FontColor(Colors.Grey.Medium);
                            x.TotalPages().FontSize(9).FontColor(Colors.Grey.Medium);
                        });
                });
            })
            .GeneratePdf(filePath);
        }

        // Estilo para encabezados de tabla
        private static IContainer CellHeaderStyle(IContainer container)
        {
            return container
                .Background(Colors.Blue.Medium)
                .Padding(8)
                .DefaultTextStyle(x => x.FontColor(Colors.White).FontSize(10));
        }

        // Estilo para celdas de datos
        private static IContainer CellDataStyle(IContainer container, string backgroundColor)
        {
            return container
                .Background(backgroundColor)
                .Padding(7)
                .BorderBottom(0.5f)
                .BorderColor(Colors.Grey.Lighten1);
        }
    }
}