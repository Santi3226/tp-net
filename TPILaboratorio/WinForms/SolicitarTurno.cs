using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using DTOs;
using Domain.Model;
using API.Clients;

namespace WinForms
{
    public partial class SolicitarTurno : Form
    {
        private PacienteDTO paciente;
        public SolicitarTurno(PacienteDTO pacienteLogueado)
        {
            InitializeComponent();
            paciente = pacienteLogueado;
        }

        private async void SolicitarTurno_Load(object sender, EventArgs e)
        {
            IEnumerable<TipoAnalisisDTO> tiposAnalisis = await TipoAnalisisApiClient.GetAllAsync();
            tipoAnalisisCombo.Items.Clear();
            tipoAnalisisCombo.DataSource = tiposAnalisis.ToList();
            tipoAnalisisCombo.DisplayMember = "Nombre";
            tipoAnalisisCombo.ValueMember = "Id";
            IEnumerable<CentroAtencionDTO> centros = await CentroAtencionApiClient.GetAllAsync();
            centroAtencionCombo.Items.Clear();
            centroAtencionCombo.DataSource = centros.ToList();
            centroAtencionCombo.DisplayMember = "Nombre";
            centroAtencionCombo.ValueMember = "Id";
        }

        private async void solicitarBtn_Click(object sender, EventArgs e)
        {
            if (fechaTurnoCalendario.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser posterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TurnoDTO turnoACrear = new TurnoDTO()
                {
                    Estado = "Pendiente",
                    RecibeMail = mailCheckBox.Checked ? true : false,
                    FechaHoraReserva = DateTime.Now,
                    Receta = "-",
                    FechaHoraExtraccion = fechaTurnoCalendario.Value,
                    Observaciones = "",
                    IdPaciente = paciente.Id,
                    IdTipoAnalisis = (int)tipoAnalisisCombo.SelectedValue,
                    IdCentroAtencion = (int)centroAtencionCombo.SelectedValue
                };
                await TurnoApiClient.AddAsync(turnoACrear);
                MessageBox.Show("Turno solicitado exitosamente.", "Turno solicitado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
