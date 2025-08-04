using Application.Services;
using Data;
using Domain.Model;
using DTOs;

namespace WinForms
{
    public partial class BorrarCA : Form
    {
        public BorrarCA(CentroAtencionDTO ca)
        {
            InitializeComponent();
        }

        private void BorrarCA_Load(object sender, EventArgs e)
        {
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboId.Text);
            bool delete = CentroAtencionService.Delete(id);
            if (delete)
            {
                MessageBox.Show("Centro de Atencion N°" + id + " borrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Centro de Atencion N°" + id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
