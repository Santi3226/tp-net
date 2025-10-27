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
    public partial class ModificarTipo : Form
    {
        private TipoAnalisisDTO tipoAnalisis;
        public ModificarTipo(TipoAnalisisDTO tipoAModificar)
        {
            InitializeComponent();
            tipoAnalisis = tipoAModificar;
        }

        private void importeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarTipo_Load(object sender, EventArgs e)
        {
            nombreTextBox.PlaceholderText = tipoAnalisis.Nombre;
            importeTextBox.PlaceholderText = (tipoAnalisis.Importe).ToString();
        }

        private async void modificarBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) && string.IsNullOrWhiteSpace(importeTextBox.Text))
            {
                MessageBox.Show("Debe llenar al menos un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                TipoAnalisisDTO tipoAnalisisDTO = new TipoAnalisisDTO
                {
                    Id = tipoAnalisis.Id,
                    Nombre = nombreTextBox.Text == string.Empty ? tipoAnalisis.Nombre : nombreTextBox.Text,
                    Importe = importeTextBox.Text == string.Empty ? tipoAnalisis.Importe : float.Parse(importeTextBox.Text),
                };
                await TipoAnalisisApiClient.UpdateAsync(tipoAnalisisDTO);
                MessageBox.Show("Centro de Atencion modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
