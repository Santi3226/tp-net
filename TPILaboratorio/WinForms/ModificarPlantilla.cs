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

namespace WinForms
{
    public partial class ModificarPlantilla : Form
    {
        private PlantillaAnalisisDTO plantillaAnalisis;
        public ModificarPlantilla(PlantillaAnalisisDTO plantillaAModificar)
        {
            InitializeComponent();
            plantillaAnalisis = plantillaAModificar;
        }

        private void ModificarPlantilla_Load(object sender, EventArgs e)
        {
            horasAyunoTextBox.PlaceholderText = plantillaAnalisis.HsAyuno;
            preparacionTextBox.PlaceholderText = plantillaAnalisis.Preparacion;
            diasPrevistosTextBox.PlaceholderText = (plantillaAnalisis.DiasPrevistos).ToString();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            PlantillaAnalisisService plantillaService = new PlantillaAnalisisService();
            if (string.IsNullOrWhiteSpace(horasAyunoTextBox.Text) && string.IsNullOrWhiteSpace(preparacionTextBox.Text) && string.IsNullOrWhiteSpace(diasPrevistosTextBox.Text))
            {
                MessageBox.Show("Debe llenar al menos un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                PlantillaAnalisisDTO plantillaAnalisisDTO = new PlantillaAnalisisDTO
                {
                    Id = plantillaAnalisis.Id,
                    HsAyuno = horasAyunoTextBox.Text == string.Empty ? plantillaAnalisis.HsAyuno : horasAyunoTextBox.Text,
                    Preparacion = preparacionTextBox.Text == string.Empty ? plantillaAnalisis.Preparacion : preparacionTextBox.Text,
                    DiasPrevistos = diasPrevistosTextBox.Text == string.Empty ? plantillaAnalisis.DiasPrevistos : int.Parse(diasPrevistosTextBox.Text)
                };
                bool update = plantillaService.Update(plantillaAnalisisDTO);
                if (update)
                {
                    MessageBox.Show("Plantilla análisis modificada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la plantilla análisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
