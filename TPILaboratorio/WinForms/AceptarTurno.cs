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
using API.Clients;
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

        private async void aceptarBtn_Click(object sender, EventArgs e)
        {
            TurnoDTO turnoAceptado = new TurnoDTO()
            {
                Id = turno.Id,
                RecibeMail = turno.RecibeMail,
                Estado = "Reservado",
                Receta = turno.Receta,
                Observaciones = observacionesTextBox.Text == string.Empty ? turno.Observaciones : observacionesTextBox.Text,
                FechaHoraExtraccion = turno.FechaHoraExtraccion,
                FechaHoraReserva = turno.FechaHoraReserva,
                IdPaciente = turno.IdPaciente,
                IdTipoAnalisis = turno.IdTipoAnalisis,
                IdCentroAtencion = turno.IdCentroAtencion
            };
            await TurnoApiClient.UpdateAsync(turnoAceptado);
            MessageBox.Show("Turno Aceptado.", "Aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
