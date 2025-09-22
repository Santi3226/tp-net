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

        private void GetOneAndLoad(int id)
        {
            try
            {
                PacienteService pacienteService = new PacienteService();
                this.dataGridViewPac.DataSource = null;
                List<PacienteDTO> list = new List<PacienteDTO>();
                list.Add(pacienteService.Get(id));
                this.dataGridViewPac.DataSource = list;
                if (dataGridViewPac.Columns.Contains("Contraseña"))
                {
                    dataGridViewPac.Columns["Contraseña"].Visible = false;
                }
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
                PacienteService pacienteService = new PacienteService();
                this.dataGridViewPac.DataSource = null;
                this.dataGridViewPac.DataSource = pacienteService.GetAll();
                this.dataGridViewPac.Columns[7].Visible = false;
                if (dataGridViewPac.Columns.Contains("Contraseña"))
                {
                    dataGridViewPac.Columns["Contraseña"].Visible = false;
                }
                this.comboId.DataSource = null;
                this.comboId.DataSource = pacienteService.GetAll();
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
                PacienteService pacienteService = new PacienteService();
                this.dataGridViewPac.DataSource = null;
                this.dataGridViewPac.DataSource = pacienteService.GetAll();
                if (dataGridViewPac.Columns.Contains("Contraseña"))
                {
                    dataGridViewPac.Columns["Contraseña"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de Pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            PacienteService pacienteService = new PacienteService();
            if (dataGridViewPac.SelectedRows.Count == 0)
            {
                MessageBox.Show($"Seleccionar un Paciente para Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var p = (PacienteDTO)dataGridViewPac.SelectedRows[0].DataBoundItem;
                var dec = MessageBox.Show("Desea eliminar el paciente N°" + p.Id + "?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dec == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(p.Id);
                    bool delete = pacienteService.Delete(id);
                    if (delete)
                    {
                        MessageBox.Show("Paciente N°" + id + " borrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.comboId.DataSource = pacienteService.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Paciente N°" + id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
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

        private void agregarPacienteBtn_Click(object sender, EventArgs e)
        {
            PacienteService pacienteService = new PacienteService();
            AgregarPaciente form = new AgregarPaciente();
            form.ShowDialog();
            this.comboId.DataSource = pacienteService.GetAll();
        }

        private void modificarPacienteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewPac.SelectedRows.Count == 0)
            {
                MessageBox.Show($"Seleccionar un Paciente para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var ca = (PacienteDTO)dataGridViewPac.SelectedRows[0].DataBoundItem;
                ModificarPaciente form = new ModificarPaciente(ca);
                form.ShowDialog();
            }
        }
    }
}