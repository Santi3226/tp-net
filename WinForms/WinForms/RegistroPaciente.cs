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
using DTOs;

namespace WinForms
{
    public partial class RegistroPaciente : Form
    {
        private PacienteDTO paciente;

        public PacienteDTO Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public RegistroPaciente()
        {
            InitializeComponent();
        }

        private void RegistroPaciente_Load(object sender, EventArgs e)
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
                    var pac = PacienteInMemory.Pacientes;
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
                string nombre = nombreTextBox.Text;
                string apellido = apellidoTextBox.Text;
                string dni = dniTextBox.Text;
                string telefono = telefonoTextBox.Text;
                string domicilio = direccionLabel.Text;
                string email = mailTextBox.Text;
                string contraseña = contraseñaTextBox.Text;
                DateTime fechaNacimiento = fechaNacimientoCalendario.SelectionStart;
                PacienteService.Add(nombre, apellido, dni, telefono, domicilio, email, contraseña, fechaNacimiento);
                MessageBox.Show("Paciente registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
