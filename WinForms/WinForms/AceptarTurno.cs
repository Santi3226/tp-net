using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.Services;
using Data;
using Domain.Model;
using DTOs;

namespace WinForms
{
    public partial class AceptarTurno : Form
    {
        private TurnoDTO turno;
        public AceptarTurno(TurnoDTO turnoAceptado)
        {
            InitializeComponent();
            turno = turnoAceptado;
        }

        private void AceptarTurno_Load(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            if(recetaTextBox.Text == string.Empty)
            {
                MessageBox.Show("Complete el campo receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                TurnoDTO turnoAceptado = new TurnoDTO()
                {
                    Id = turno.Id,
                    RecibeMail = turno.RecibeMail,
                    Estado = "Reservado",
                    Receta = recetaTextBox.Text,
                    Observaciones = observacionesTextBox.Text == string.Empty ? turno.Observaciones : observacionesTextBox.Text,
                    FechaHoraExtraccion = turno.FechaHoraExtraccion,
                    FechaHoraReserva = turno.FechaHoraReserva,
                    IdPaciente = turno.IdPaciente,
                    IdTipoAnalisis = turno.IdTipoAnalisis
                };
                TurnoService turnoService = new TurnoService();
                bool aceptado = turnoService.Update(turnoAceptado);
                if (aceptado)
                {
                    MessageBox.Show("Turno aceptado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
