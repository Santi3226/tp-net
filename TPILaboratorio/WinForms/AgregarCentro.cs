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
    public partial class AgregarCentro : Form
    {
        public AgregarCentro()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            CentroAtencionService centroAtencionService = new CentroAtencionService();
            string nombre = this.nombreTextBox.Text;
            string domicilio = this.direccionTextBox.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(domicilio))
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                CentroAtencionDTO centro = new CentroAtencionDTO
                { Nombre = nombre, Domicilio = domicilio };
                CentroAtencionDTO ca = centroAtencionService.Add(centro);
                MessageBox.Show("Centro de Atencion registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
