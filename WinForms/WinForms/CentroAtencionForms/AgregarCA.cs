using Application.Services;
using Domain.Model;
using DTOs;
using static System.Net.Mime.MediaTypeNames;

namespace WinForms
{
    public partial class AgregarCA : Form
    {
        public AgregarCA()
        {
            InitializeComponent();
        }

        private void AgregarCA_Load(object sender, EventArgs e)
        {
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            CentroAtencionService centroAtencionService = new CentroAtencionService();
            string nombre = this.textBoxNombre.Text;
            string domicilio = this.textBoxDomicilio.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(domicilio))
            {
                MessageBox.Show("Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                CentroAtencionDTO centro = new CentroAtencionDTO
                { Nombre = nombre, Domicilio = domicilio };
                CentroAtencionDTO ca = centroAtencionService.Add(centro);
                MessageBox.Show("Centro de Atencion " + ca.Nombre + " N°" + ca.Id + " registrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
