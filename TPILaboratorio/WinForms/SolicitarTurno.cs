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
using Application.Services;

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

        private void SolicitarTurno_Load(object sender, EventArgs e)
        {
            TipoAnalisisRepository tipoAnalisisRepository = new TipoAnalisisRepository();
            var tiposAnalisis = tipoAnalisisRepository.GetAll();
            tipoAnalisisCombo.Items.Clear();
            tipoAnalisisCombo.DataSource = tiposAnalisis.ToList();
            tipoAnalisisCombo.DisplayMember = "Nombre";
            tipoAnalisisCombo.ValueMember = "Id";
            CentroRepository centroRepository= new CentroRepository();
            var centros = centroRepository.GetAll();
            centroAtencionCombo.Items.Clear();
            centroAtencionCombo.DataSource = centros.ToList();
            centroAtencionCombo.DisplayMember = "Nombre";
            centroAtencionCombo.ValueMember = "Id";
        }

        private void solicitarBtn_Click(object sender, EventArgs e)
        {
            if (fechaTurnoCalendario.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser posterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TurnoRepository turnoRepository = new TurnoRepository();
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
                TurnoService turnoService = new TurnoService();
                turnoService.Add(turnoACrear);
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
