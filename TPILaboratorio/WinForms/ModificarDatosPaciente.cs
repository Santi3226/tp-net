using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using Data;
using Domain.Model;
using Application.Services;


namespace WinForms
{
    public partial class ModificarDatosPaciente : Form
    {
        private PacienteDTO paciente;
        public ModificarDatosPaciente(PacienteDTO pacienteLogueado)
        {
            InitializeComponent();
            paciente = pacienteLogueado;
        }

        private void ModificarDatosPaciente_Load(object sender, EventArgs e)
        {
            nombreTextBox.PlaceholderText = paciente.Nombre;
            apellidoTextBox.PlaceholderText = paciente.Apellido;
            telefonoTextBox.PlaceholderText = paciente.Telefono;
            direccionTextBox.PlaceholderText = paciente.Domicilio;
            mailTextBox.PlaceholderText = paciente.Email;
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == string.Empty && apellidoTextBox.Text == string.Empty && mailTextBox.Text == string.Empty && telefonoTextBox.Text == string.Empty && direccionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe completar al menos un campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                if (mailTextBox.Text != string.Empty && !mailTextBox.Text.Contains('@'))
                {
                    MessageBox.Show("Debe ingresar un mail válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PacienteDTO pacienteModificado = new PacienteDTO()
                {
                    Id = paciente.Id,
                    Nombre = nombreTextBox.Text == string.Empty ? paciente.Nombre : nombreTextBox.Text,
                    Apellido = apellidoTextBox.Text == string.Empty ? paciente.Apellido : apellidoTextBox.Text,
                    Dni = paciente.Dni,
                    Telefono = telefonoTextBox.Text == string.Empty ? paciente.Telefono : telefonoTextBox.Text,
                    Domicilio = direccionTextBox.Text == string.Empty ? paciente.Domicilio : direccionTextBox.Text,
                    Email = mailTextBox.Text == string.Empty ? paciente.Email : mailTextBox.Text,
                    Contraseña = paciente.Contraseña,
                    FechaNacimiento = paciente.FechaNacimiento,
                    Tipo = paciente.Tipo
                };
                PacienteService pacienteService = new PacienteService();
                bool modificado = pacienteService.Update(pacienteModificado);

                if (modificado)
                {
                    MessageBox.Show("Datos modificados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
