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

        private void menuCentrosBtn_Click(object sender, EventArgs e)
        {
            MostrarCA form = new MostrarCA();
            form.ShowDialog();
        }

        private void menuPacienteBtn_Click(object sender, EventArgs e)
        {
            MostrarPaciente form = new MostrarPaciente();
            form.ShowDialog();
        }
    }
}
