using Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ModificarCA : Form
    {
        public ModificarCA()
        {
            InitializeComponent();
        }

        private void ModificarCA_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }
        private void GetAllAndLoad()
        {
            try
            {
                this.comboId.DataSource = null;
                this.comboId.DataSource = CentroAtencionService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Centros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string domicilio = textBoxDomicilio.Text;
            int id = Convert.ToInt32(comboId.Text);
            bool update = CentroAtencionService.Update(id, nombre, domicilio);
            if (update)
            {
                MessageBox.Show("Centro de Atencion N°" + id + " modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el Centro de Atencion N°" + id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}