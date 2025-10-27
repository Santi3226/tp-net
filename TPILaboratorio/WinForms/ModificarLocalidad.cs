using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Clients;
using Domain.Model;
using DTOs;

namespace WinForms
{
    public partial class ModificarLocalidad : Form
    {
        private LocalidadDTO localidad;
        public ModificarLocalidad(LocalidadDTO localidadAModificar)
        {
            InitializeComponent();
            localidad = localidadAModificar;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void modificarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) && string.IsNullOrWhiteSpace(codigoPostalTextBox.Text))
            {
                MessageBox.Show("Debe llenar al menos un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                LocalidadDTO localidadDTO = new LocalidadDTO
                {
                    Id = localidad.Id,
                    Nombre = nombreTextBox.Text == string.Empty ? localidad.Nombre : nombreTextBox.Text,
                    CodigoPostal = codigoPostalTextBox.Text == string.Empty ? localidad.CodigoPostal : codigoPostalTextBox.Text
                };
                await LocalidadApiClient.UpdateAsync(localidadDTO);
                MessageBox.Show("Localidad modificada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ModificarLocalidad_Load(object sender, EventArgs e)
        {
            nombreTextBox.PlaceholderText = localidad.Nombre;
            codigoPostalTextBox.PlaceholderText = localidad.CodigoPostal;
        }
    }
}
