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

        private async void ModificarCentro_Load(object sender, EventArgs e)
        {
            nombreTextBox.PlaceholderText = centro.Nombre;
            direccionTextBox.PlaceholderText = centro.Domicilio;
            IEnumerable<LocalidadDTO> localidades = await LocalidadApiClient.GetAllAsync();
            localidadCombo.Items.Clear();
            localidadCombo.DataSource = localidades.ToList();
            localidadCombo.DisplayMember = "Nombre";
            localidadCombo.ValueMember = "Id";
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void modificarBtn_Click(object sender, EventArgs e)
        {
            CentroAtencionDTO centroAModificar = new CentroAtencionDTO
            {
                Id = centro.Id,
                Nombre = nombreTextBox.Text == string.Empty ? centro.Nombre : nombreTextBox.Text,
                Domicilio = direccionTextBox.Text == string.Empty ? centro.Domicilio : direccionTextBox.Text,
                IdLocalidad = (int)this.localidadCombo.SelectedValue
            };
            await CentroAtencionApiClient.UpdateAsync(centroAModificar);
            MessageBox.Show("Centro de Atencion modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
