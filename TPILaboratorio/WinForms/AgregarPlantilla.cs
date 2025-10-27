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
using Application.Services;
using DTOs;

namespace WinForms
{
    public partial class AgregarPlantilla : Form
    {
        public AgregarPlantilla()
        {
            InitializeComponent();
        }

        private void AgregarPlantilla_Load(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void agregarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(horasAyunoTextBox.Text) || string.IsNullOrWhiteSpace(preparacionTextBox.Text) || string.IsNullOrWhiteSpace(diasPrevistosTextBox.Text))
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                PlantillaAnalisisDTO plantillaAnalisis = new PlantillaAnalisisDTO
                { HsAyuno = horasAyunoTextBox.Text, Preparacion = preparacionTextBox.Text, DiasPrevistos = int.Parse(diasPrevistosTextBox.Text) };
                await PlantillaAnalisisApiClient.AddAsync(plantillaAnalisis);
                MessageBox.Show("Plantilla de análisis registrada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void diasPrevistosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
