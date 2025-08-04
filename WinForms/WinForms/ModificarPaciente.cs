using Application.Services;
using DTOs;
using System;
using Domain.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ModificarPaciente : Form
    {
        public ModificarPaciente()
        {
            InitializeComponent();
        }

        private void ModificarPaciente_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }
        private void GetAllAndLoad()
        {
            try
            {
                this.comboId.DataSource = null;
                this.comboId.DataSource = PacienteService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            string nombre = nombreText.Text;
            string dni = dniText.Text;
            string apellido = apellidoText.Text;
            string contraseña = contraseñaText.Text;
            string domicilio = domicilioText.Text;
            string email = emailText.Text;
            string celular = celularText.Text;
            DateTime fechaNacimiento = fechaNacimientoCalendario.SelectionStart;
            int id = Convert.ToInt32(comboId.Text);
            Paciente p = new Paciente(id, nombre, apellido, dni, celular, domicilio, email, contraseña, fechaNacimiento);
            bool update = PacienteService.Update(p);
            if (update)
            {
                MessageBox.Show("Centro de Atencion N°" + id + " modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el Centro de Atencion N°" + id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
