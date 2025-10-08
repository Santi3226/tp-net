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
    public partial class AgregarTipo : Form
    {
        public AgregarTipo()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            TipoAnalisisService tipoAnalisisService = new TipoAnalisisService();
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) || string.IsNullOrWhiteSpace(importeTextBox.Text))
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                TipoAnalisisDTO tipoAnalisis = new TipoAnalisisDTO
                { Nombre = nombreTextBox.Text, Importe = float.Parse(importeTextBox.Text), IdPlantillaAnalisis = (int)this.plantillaCombo.SelectedValue };
                TipoAnalisisDTO ta = tipoAnalisisService.Add(tipoAnalisis);
                MessageBox.Show("Centro de Atencion registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void importeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AgregarTipo_Load(object sender, EventArgs e)
        {
            PlantillaAnalisisRepository plantillaRepository = new PlantillaAnalisisRepository();
            var plantillas = plantillaRepository.GetAll();
            plantillaCombo.Items.Clear();
            plantillaCombo.DataSource = plantillas.ToList();
            plantillaCombo.DisplayMember = "Preparacion";
            plantillaCombo.ValueMember = "Id";
        }
    }
}
