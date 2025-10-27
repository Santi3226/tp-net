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
using Data;
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

        private async void agregarBtn_Click(object sender, EventArgs e)
        {
            string nombre = this.nombreTextBox.Text;
            string domicilio = this.direccionTextBox.Text;
            int localidadId = (int)this.localidadCombo.SelectedValue;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(domicilio) || string.IsNullOrEmpty(localidadId.ToString()))
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                CentroAtencionDTO centro = new CentroAtencionDTO
                { Nombre = nombre, Domicilio = domicilio, IdLocalidad = localidadId};
                await CentroAtencionApiClient.AddAsync(centro);
                MessageBox.Show("Centro de Atencion registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private async void AgregarCentro_Load(object sender, EventArgs e)
        {
            IEnumerable<LocalidadDTO> localidades = await LocalidadApiClient.GetAllAsync();
            localidadCombo.Items.Clear();
            localidadCombo.DataSource = localidades.ToList();
            localidadCombo.DisplayMember = "Nombre";
            localidadCombo.ValueMember = "Id";
        }
    }
}
