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
using Data;

namespace WinForms
{
    public partial class ModificarPaciente : Form
    {
        public ModificarPaciente(PacienteDTO p)
        {
            InitializeComponent();
            textId.Text = (p.Id).ToString();
            nombreText.Text = p.Nombre;
            apellidoText.Text = p.Apellido;
            domicilioText.Text = p.Domicilio;
            contraseñaText.Text = p.Contraseña;
            celularText.Text = p.Telefono;
            dniText.Text = p.Dni;
            fechaNacimientoCalendario.SetDate(p.FechaNacimiento);
            emailText.Text = p.Email;
        }

        private void ModificarPaciente_Load(object sender, EventArgs e)
        {
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreText.Text) || string.IsNullOrWhiteSpace(apellidoText.Text) ||
                string.IsNullOrWhiteSpace(dniText.Text) || string.IsNullOrWhiteSpace(celularText.Text) ||
                string.IsNullOrWhiteSpace(domicilioText.Text) || string.IsNullOrWhiteSpace(contraseñaText.Text) ||
                string.IsNullOrWhiteSpace(dniText.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            string nombre = nombreText.Text;
            string dni = dniText.Text;
            string apellido = apellidoText.Text;
            string contraseña = contraseñaText.Text;
            string domicilio = domicilioText.Text;
            string email = emailText.Text;
            string celular = celularText.Text;
            DateTime fechaNacimiento = fechaNacimientoCalendario.SelectionStart;
            Paciente p = new Paciente(Convert.ToInt32(textId.Text), nombre, apellido, dni, celular, domicilio, email, contraseña, fechaNacimiento);
            bool update = PacienteService.Update(p);
            if (update)
            {
                MessageBox.Show("Centro de Atencion N°" + textId.Text + " modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el Centro de Atencion N°" + textId.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        }
    }
}
