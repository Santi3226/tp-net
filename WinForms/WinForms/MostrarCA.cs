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
    public partial class MostrarCA : Form
    {
        public MostrarCA()
        {
            InitializeComponent();
        }

        private void MostrarCA_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetAll();
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
                this.dataGridViewCA.DataSource = null;
                List<CentroAtencionDTO> list = new List<CentroAtencionDTO>();
                list.Add(CentroAtencionService.Get(id));
                this.dataGridViewCA.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Centros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetAllAndLoad()
        {
            try
            {
                this.dataGridViewCA.DataSource = null;
                this.dataGridViewCA.DataSource = CentroAtencionService.GetAll();
                this.comboId.DataSource = null;
                this.comboId.DataSource = CentroAtencionService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Centros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetAll()
        {
            try
            {
                this.dataGridViewCA.DataSource = null;
                this.dataGridViewCA.DataSource = CentroAtencionService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Centros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}   
