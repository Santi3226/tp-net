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
using DTOs;

namespace WinForms
{
    public partial class AgregarLocalidad : Form
    {
        public AgregarLocalidad()
        {
            InitializeComponent();
        }

        private void AgregarLocalidad_Load(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            LocalidadService localidadService = new LocalidadService();
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) || string.IsNullOrWhiteSpace(codigoPostalTextBox.Text))
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                LocalidadDTO localidad = new LocalidadDTO
                { Nombre = nombreTextBox.Text, CodigoPostal = codigoPostalTextBox.Text };
                LocalidadDTO lo = localidadService.Add(localidad);
                MessageBox.Show("Localidad registrada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
