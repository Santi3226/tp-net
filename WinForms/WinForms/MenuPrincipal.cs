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

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarCA form = new AgregarCA();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BorrarCA form = new BorrarCA();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarCA form = new ModificarCA();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*AgregarPaciente form = new AgregarPaciente();
            form.ShowDialog();*/
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            /*BorrarPaciente form = new BorrarPaciente();
            form.ShowDialog();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarPaciente form = new ModificarPaciente();
            form.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
         
        }
    }
}
