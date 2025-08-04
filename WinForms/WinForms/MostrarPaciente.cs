using Application.Services;
using DTOs;
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
    public partial class MostrarPaciente : Form
    {
        public MostrarPaciente()
        {
            InitializeComponent();
        }

        private void MostrarPaciente_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboId.Text);
            GetOneAndLoad(id);
        }
        private void GetOneAndLoad(int id)
        {
            try
            {
                this.dataGridViewPac.DataSource = null;
                List<PacienteDTO> list = new List<PacienteDTO>();
                list.Add(PacienteService.Get(id));
                this.dataGridViewPac.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetAllAndLoad()
        {
            try
            {
                this.dataGridViewPac.DataSource = null;
                this.dataGridViewPac.DataSource = PacienteService.GetAll();
                this.comboId.DataSource = null;
                this.comboId.DataSource = PacienteService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetAll()
        {
            try
            {
                this.dataGridViewPac.DataSource = null;
                this.dataGridViewPac.DataSource = PacienteService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboId.Text);
            GetOneAndLoad(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}   

