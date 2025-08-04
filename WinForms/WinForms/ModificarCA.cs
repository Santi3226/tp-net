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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string domicilio = textBoxDomicilio.Text;
            int id = Convert.ToInt32(textBoxId.Text);
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