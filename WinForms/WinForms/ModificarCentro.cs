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
using Domain.Model;
using DTOs;
using static System.Net.Mime.MediaTypeNames;

namespace WinForms
{
    public partial class ModificarCentro : Form
    {
        private CentroAtencionDTO centro;
        public ModificarCentro(CentroAtencionDTO centroAModificar)
        {
            InitializeComponent();
            centro = centroAModificar;
        }

        private void ModificarCentro_Load(object sender, EventArgs e)
        {
            nombreTextBox.PlaceholderText = centro.Nombre;
            direccionTextBox.PlaceholderText = centro.Domicilio;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            CentroAtencionService centroAtencionService = new CentroAtencionService();
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) && string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                MessageBox.Show("Debe llenar al menos un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                CentroAtencionDTO centroAModificar = new CentroAtencionDTO
                {
                    Id = centro.Id,
                    Nombre = nombreTextBox.Text == string.Empty ? centro.Nombre : nombreTextBox.Text,
                    Domicilio = direccionTextBox.Text == string.Empty ? centro.Domicilio : direccionTextBox.Text,
                };
                bool update = centroAtencionService.Update(centroAModificar);
                if (update)
                {
                    MessageBox.Show("Centro de Atencion modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el Centro de Atencion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }
    }
}
