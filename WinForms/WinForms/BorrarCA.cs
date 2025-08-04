using Application.Services;
using Data;
using Domain.Model;
using DTOs;

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
            this.GetAllAndLoad();
        }

        private void button1_Click(object sender, EventArgs e)
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
            this.Close();
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
    }
}
