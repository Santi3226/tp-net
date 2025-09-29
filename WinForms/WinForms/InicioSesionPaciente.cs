using Data;
using Domain.Model;
using DTOs;
using System.Windows.Forms;
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
            if (this.ValidateEntry())
            {
                PacienteDTO? pacienteLogueado = this.ValidatePacienteAsync();
                if (pacienteLogueado != null)
                {
                    MessageBox.Show(Text = "Bienvenido!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emailTextBox.Clear();
                    contraseñaTextBox.Clear();
                    emailTextBox.Focus();
                    HomePaciente form = new HomePaciente(pacienteLogueado);
                    form.FormClosed += (s, args) => this.Show();
                    this.Hide();
                    form.ShowDialog();
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

        private PacienteDTO? ValidatePacienteAsync()
        {
            var pacienteRepository = new PacienteRepository();
            var pacientes = pacienteRepository.GetAll();
            string email = this.emailTextBox.Text.Trim();
            string contraseña = this.contraseñaTextBox.Text.Trim();

            foreach (var p in pacientes)
            {
                if (p.Email == email && p.Contraseña == contraseña)
                {
                    return new PacienteDTO
                    {
                        Id = p.Id,
                        Nombre = p.Nombre,
                        Apellido = p.Apellido,
                        Dni = p.Dni,
                        Telefono = p.Telefono,
                        Domicilio = p.Domicilio,
                        Email = p.Email,
                        FechaNacimiento = p.FechaNacimiento,
                        Tipo = p.Tipo,
                        Contraseña = p.Contraseña
                    };
                }
            }
            return null;
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
    }
}
