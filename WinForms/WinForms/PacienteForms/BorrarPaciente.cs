using Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class BorrarPaciente : Form
    {
        public BorrarPaciente()
        {
            InitializeComponent();
        }

        private void BorrarPaciente_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            PacienteService pacienteService = new PacienteService();
            int id = Convert.ToInt32(sexoCombo.Text);
            bool delete = pacienteService.Delete(id);
            if (delete)
            {
                MessageBox.Show("Paciente N°" + id + " borrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Paciente N°" + id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void GetAllAndLoad()
        {
            PacienteService pacienteService = new PacienteService();
            try
            {
                this.sexoCombo.DataSource = null;
                this.sexoCombo.DataSource = pacienteService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
