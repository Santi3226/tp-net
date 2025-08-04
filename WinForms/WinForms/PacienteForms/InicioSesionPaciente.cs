using System.Windows.Forms;
using DTOs;
using Data;
using WinForms;

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

        private void iniciarSesionBtn_Click(object sender, EventArgs e)
        {
            PacienteApiClient client = new PacienteApiClient();

            if (this.ValidateEntry())
            {
                if (this.ValidatePacienteAsync())
                {
                    // acá iria la iniciacion del menu principal
                    MessageBox.Show(Text = "Bienvenido!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    this.Hide();
                    menuPrincipal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTextBox.Clear();
                    contraseñaTextBox.Clear();
                    emailTextBox.Focus();
                }
            }
        }

        private bool ValidateEntry()
        {
            bool isValid = true;

            if (this.emailTextBox.Text == string.Empty || this.contraseñaTextBox.Text == string.Empty)
            {
                isValid = false;
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!this.emailTextBox.Text.Contains('@'))
            {
                isValid = false;
                MessageBox.Show("Por favor, ingrese un mail válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private bool ValidatePacienteAsync()
        {
            var pacientes = PacienteInMemory.Pacientes;
            string email = this.emailTextBox.Text.Trim();
            string contraseña = this.contraseñaTextBox.Text.Trim();

            foreach (var p in pacientes)
            {
                if (p.Email == email && p.Contraseña == contraseña)
                {
                    return true;
                }
            }
            return false;
        }

        private void InicioSesionPaciente_Load(object sender, EventArgs e)
        {

        }

        private void registrarmeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            emailTextBox.Clear();
            contraseñaTextBox.Clear();
            RegistroPaciente registroPaciente = new RegistroPaciente();
            registroPaciente.ShowDialog();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
