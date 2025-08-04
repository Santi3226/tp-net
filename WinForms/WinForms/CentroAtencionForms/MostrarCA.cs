using Application.Services;
using Domain.Model;
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

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewCA.SelectedRows.Count == 0)
            {
                MessageBox.Show($"Seleccionar un Centro para Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var ca = (CentroAtencionDTO)dataGridViewCA.SelectedRows[0].DataBoundItem;
                var dec = MessageBox.Show("Desea eliminar el centro N°" + ca.Id + "?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dec == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(ca.Id);
                    bool delete = CentroAtencionService.Delete(id);
                    if (delete)
                    {
                        MessageBox.Show("Centro de Atencion N°" + id + " borrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.comboId.DataSource = CentroAtencionService.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Centro de Atencion N°" + id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void modificarCaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewCA.SelectedRows.Count == 0)
            {
                MessageBox.Show($"Seleccionar un Centro para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var ca = (CentroAtencionDTO)dataGridViewCA.SelectedRows[0].DataBoundItem;
                ModificarCA form = new ModificarCA(ca);
                form.ShowDialog();
            }
        }

        private void agregarCaBtn_Click(object sender, EventArgs e)
        {
            AgregarCA agregarCA = new AgregarCA();
            agregarCA.ShowDialog();
            this.comboId.DataSource = CentroAtencionService.GetAll();
        }

        private void mostrarUnoBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboId.Text);
            GetOneAndLoad(id);
        }

        private void mostrarTodosBtn_Click(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}   
