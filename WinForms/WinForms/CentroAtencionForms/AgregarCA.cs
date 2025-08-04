using Application.Services;
using Domain.Model;

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
            string nombre = this.textBoxNombre.Text;
            string domicilio = this.textBoxDomicilio.Text;
            Domain.Model.CentroAtencion ca = CentroAtencionService.Add(nombre, domicilio);
            MessageBox.Show("Centro de Atencion " + ca.Nombre + " N°" + ca.Id + " registrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
