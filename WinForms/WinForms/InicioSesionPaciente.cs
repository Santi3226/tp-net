using System.Windows.Forms;
using DTOs;

namespace WinForms
{
    public partial class InicioSesionPaciente : Form
    {
        private PacienteDTO paciente;

        public PacienteDTO Paciente
        {
            get { return paciente; }
            set
            {
                paciente = value;
            }
        }

        public InicioSesionPaciente()
        {
            InitializeComponent();
        }

        private async void iniciarSesionBtn_Click(object sender, EventArgs e)
        {
            PacienteApiClient client = new PacienteApiClient();

            if (this.ValidateEntry())
            {
                if (await this.ValidatePacienteAsync())
                {
                    // ac� iria la iniciacion del menu principal
                }
            }
        }

        private bool ValidateEntry()
        {
            bool isValid = true;
            
            if (this.emailTextBox.Text == string.Empty || this.contrase�aTextBox.Text == string.Empty)
            {
                isValid = false;
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!this.emailTextBox.Text.Contains('@'))
            {
                isValid = false;
                MessageBox.Show("Por favor, ingrese un mail v�lido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                return isValid;
        }

        private async Task<bool> ValidatePacienteAsync()
        {
            var pacientes = await PacienteApiClient.GetAllAsync();
            string email = this.emailTextBox.Text.Trim();
            string contrase�a = this.contrase�aTextBox.Text.Trim();

            foreach(var p in pacientes)
            {
                if (p.Email == email && p.Contrase�a == contrase�a)
                {
                    this.Paciente = p;
                    return true;
                }
            }

            MessageBox.Show("Usuario o contrase�a incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void InicioSesionPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
