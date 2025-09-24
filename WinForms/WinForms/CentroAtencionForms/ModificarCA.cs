using Application.Services;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ModificarCA : Form
    {
        public ModificarCA(CentroAtencionDTO ca)
        {
            InitializeComponent();
            textBoxNombre.Text = ca.Nombre;
            textBoxDomicilio.Text = ca.Domicilio;
            textId.Text = (ca.Id).ToString();
        }

        private void ModificarCA_Load(object sender, EventArgs e)
        {
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            CentroAtencionService centroAtencionService = new CentroAtencionService();
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxDomicilio.Text))
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else {
            string nombre = textBoxNombre.Text;
            string domicilio = textBoxDomicilio.Text;
            int id = Convert.ToInt16(textId.Text);
            CentroAtencionDTO centro = new CentroAtencionDTO
            {
                Id = id, 
                Nombre= nombre, 
                Domicilio=domicilio 
            };
            bool update = centroAtencionService.Update(centro);
            if (update)
            {
                MessageBox.Show("Centro de Atencion N°" + textId.Text + " modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el Centro de Atencion N°" + textId.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            }
        }
    }
}