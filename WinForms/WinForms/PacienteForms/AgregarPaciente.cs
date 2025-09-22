using Application.Services;
using Data;
using Domain.Model;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinForms
{
    public partial class AgregarPaciente : Form
    {
        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void AgregarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                if (AsignPaciente())
                {
                    MessageBox.Show("Paciente registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void iniciarSesionLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private bool ValidateEntry()
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) || string.IsNullOrWhiteSpace(apellidoTextBox.Text) ||
                string.IsNullOrWhiteSpace(dniTextBox.Text) || string.IsNullOrWhiteSpace(telefonoTextBox.Text) ||
                string.IsNullOrWhiteSpace(direccionLabel.Text) || string.IsNullOrWhiteSpace(nombreTextBox.Text) ||
                string.IsNullOrWhiteSpace(dniTextBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dniTextBox.Text.Length != 8)
            {
                MessageBox.Show("Por favor, ingrese un dni válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!mailTextBox.Text.Contains('@'))
            {
                MessageBox.Show("Por favor, ingrese un mail válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (contraseñaTextBox.Text != confirmarContraseñaTextBox.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool AsignPaciente()
        {
            try
            {
                PacienteService pacienteService = new PacienteService();
                string nombre = nombreTextBox.Text;
                string apellido = apellidoTextBox.Text;
                string dni = dniTextBox.Text;
                string telefono = telefonoTextBox.Text;
                string domicilio = direccionTextBox.Text;
                string email = mailTextBox.Text;
                string contraseña = contraseñaTextBox.Text;
                DateTime fechaNacimiento = fechaNacimientoCalendario.SelectionStart;
                PacienteDTO paciente = new PacienteDTO{Id= 0, Nombre= nombre, Apellido= apellido, Dni=dni,
                Telefono= telefono, Domicilio= domicilio, Email= email, Contraseña= contraseña, 
                    FechaNacimiento= fechaNacimiento};
                pacienteService.Add(paciente);
                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void modificarLabel_Click(object sender, EventArgs e)
        {

        }
    }
}