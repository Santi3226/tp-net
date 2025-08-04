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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarCaBtn_Click(object sender, EventArgs e)
        {
            AgregarCA form = new AgregarCA();
            form.ShowDialog();
        }

        private void borrarCaBtn_Click(object sender, EventArgs e)
        {
            BorrarCA form = new BorrarCA();
            form.ShowDialog();
        }

        private void modificarCaBtn_Click(object sender, EventArgs e)
        {
            ModificarCA form = new ModificarCA();
            form.ShowDialog();
        }

        private void mostrarCaBtn_Click(object sender, EventArgs e)
        {
            MostrarCA form = new MostrarCA();
            form.ShowDialog();
        }

        private void agregarPacienteBtn_Click(object sender, EventArgs e)
        {
            RegistroPaciente registroPaciente = new RegistroPaciente();
            registroPaciente.ShowDialog();
        }

        private void borrarPacienteBtn_Click(object sender, EventArgs e)
        {
            BorrarPaciente form = new BorrarPaciente();
            form.ShowDialog();
        }

        private void modificarPacienteBtn_Click(object sender, EventArgs e)
        {
            ModificarPaciente form = new ModificarPaciente();
            form.ShowDialog();
        }

        private void mostrarPacienteBtn_Click(object sender, EventArgs e)
        {
            MostrarPaciente form = new MostrarPaciente();
            form.ShowDialog();
        }
    }
}
