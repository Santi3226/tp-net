using Application.Services;
using Data;
using Domain.Model;

namespace WinForms
{
    public partial class BorrarCA : Form
    {
        public BorrarCA()
        {
            InitializeComponent();
        }

        private void BorrarCA_Load(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            bool delete = CentroAtencionService.Delete(id);
            if (delete)
            {
            MessageBox.Show("Centro de Atencion N°" + id + " borrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Centro de Atencion N°" + id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void sexoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarDatos(object sender, EventArgs e)
        {
        }
    }
}
