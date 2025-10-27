using API.Clients;
using Data;
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
    public partial class HomePaciente : Form
    {
        private PacienteDTO paciente;
        private Dictionary<string, ToolStripMenuItem> menuItems = new Dictionary<string, ToolStripMenuItem>();
        public HomePaciente(PacienteDTO pacienteLogueado)
        {
            InitializeComponent();
            paciente = pacienteLogueado;
        }

        private async void HomePaciente_Load(object sender, EventArgs e)
        {
            pacienteMenuStrip.Items.Clear();
            if (paciente.Tipo == "Paciente")
            {
                ToolStripMenuItem solicitarTurnoToolStrip = new ToolStripMenuItem("Solicitar turno");
                solicitarTurnoToolStrip.Name = "solicitarTurnoToolStrip";
                solicitarTurnoToolStrip.Click += SolicitarTurno_Click;

                ToolStripMenuItem cancelarTurnoToolStrip = new ToolStripMenuItem("Cancelar turno");
                cancelarTurnoToolStrip.Name = "cancelarTurnoToolStrip";
                cancelarTurnoToolStrip.Click += CancelarTurno_Click;

                ToolStripMenuItem modificarDatosToolStrip = new ToolStripMenuItem("Modificar mis datos");
                modificarDatosToolStrip.Name = "modificarDatosToolStrip";
                modificarDatosToolStrip.Click += ModificarDatos_Click;

                pacienteMenuStrip.Items.Add(solicitarTurnoToolStrip);
                pacienteMenuStrip.Items.Add(cancelarTurnoToolStrip);
                pacienteMenuStrip.Items.Add(modificarDatosToolStrip);

                labelMisProximosTurnos.Visible = true;
                proximosTurnosPacienteDGV.Visible = true;

                IEnumerable<TurnoDTO> turnosDelPaciente = await TurnoApiClient.GetByPacinteIdAsync(paciente.Id);

                var turnosVista = turnosDelPaciente.Select(t => new
                {
                    t.Id,
                    t.Estado,
                    t.Receta,
                    t.Observaciones,
                    t.FechaHoraExtraccion,
                    t.FechaHoraReserva,
                }).ToList();

                proximosTurnosPacienteDGV.DataSource = turnosVista;
                this.Controls.Remove(btnGanancias);
                this.Controls.Remove(btnRecepcion);
            }
            else if (paciente.Tipo == "Administrador")
            {
                pacienteMenuStrip.Items.Clear();

                ToolStripMenuItem turnosMenu = new ToolStripMenuItem("Turnos");

                ToolStripMenuItem listarProximosTurnos = new ToolStripMenuItem("Listar próximos turnos");
                listarProximosTurnos.Click += ListarProximosTurnos_Click;

                ToolStripMenuItem listarTurnosPendientes = new ToolStripMenuItem("Listar turnos pendientes");
                listarTurnosPendientes.Click += ListarTurnosPendientes_Click;

                ToolStripMenuItem aceptarTurno = new ToolStripMenuItem("Aceptar turno");
                aceptarTurno.Click += AceptarTurno_Click;

                ToolStripMenuItem rechazarTurno = new ToolStripMenuItem("Rechazar turno");
                rechazarTurno.Click += RechazarTurno_Click;

                ToolStripMenuItem eliminarTurno = new ToolStripMenuItem("Eliminar turno");
                eliminarTurno.Click += EliminarTurno_Click;

                turnosMenu.DropDownItems.Add(listarProximosTurnos);
                turnosMenu.DropDownItems.Add(listarTurnosPendientes);
                turnosMenu.DropDownItems.Add(aceptarTurno);
                turnosMenu.DropDownItems.Add(rechazarTurno);
                turnosMenu.DropDownItems.Add(eliminarTurno);
                menuItems["aceptarTurno"] = aceptarTurno;
                menuItems["rechazarTurno"] = rechazarTurno;
                menuItems["eliminarTurno"] = eliminarTurno;
                aceptarTurno.Enabled = false;
                rechazarTurno.Enabled = false;
                eliminarTurno.Enabled = false;

                ToolStripMenuItem usuariosMenu = new ToolStripMenuItem("Usuarios");

                ToolStripMenuItem listarUsuarios = new ToolStripMenuItem("Listar usuarios");
                listarUsuarios.Click += ListarUsuarios_Click;

                ToolStripMenuItem eliminarUsuario = new ToolStripMenuItem("Eliminar usuario");
                eliminarUsuario.Click += EliminarUsuario_Click;

                usuariosMenu.DropDownItems.Add(listarUsuarios);
                usuariosMenu.DropDownItems.Add(eliminarUsuario);
                menuItems["eliminarUsuario"] = eliminarUsuario;
                eliminarUsuario.Enabled = false;

                ToolStripMenuItem centrosMenu = new ToolStripMenuItem("Centros de atención");

                ToolStripMenuItem listarCentros = new ToolStripMenuItem("Listar centros");
                listarCentros.Click += ListarCentros_Click;

                ToolStripMenuItem anadirCentro = new ToolStripMenuItem("Añadir centro");
                anadirCentro.Click += AnadirCentro_Click;

                ToolStripMenuItem modificarCentro = new ToolStripMenuItem("Modificar centro");
                modificarCentro.Click += ModificarCentro_Click;

                ToolStripMenuItem eliminarCentro = new ToolStripMenuItem("Eliminar centro");
                eliminarCentro.Click += EliminarCentro_Click;

                centrosMenu.DropDownItems.Add(listarCentros);
                centrosMenu.DropDownItems.Add(anadirCentro);
                centrosMenu.DropDownItems.Add(modificarCentro);
                centrosMenu.DropDownItems.Add(eliminarCentro);
                menuItems["modificarCentro"] = modificarCentro;
                menuItems["eliminarCentro"] = eliminarCentro;
                modificarCentro.Enabled = false;
                eliminarCentro.Enabled = false;

                ToolStripMenuItem tiposAnalisisMenu = new ToolStripMenuItem("Tipo de análisis");

                ToolStripMenuItem listarTipos = new ToolStripMenuItem("Listar tipos");
                listarTipos.Click += ListarTipos_Click;

                ToolStripMenuItem anadirTipo = new ToolStripMenuItem("Añadir tipo");
                anadirTipo.Click += AnadirTipo_Click;

                ToolStripMenuItem modificarTipo = new ToolStripMenuItem("Modificar tipo");
                modificarTipo.Click += ModificarTipo_Click;

                ToolStripMenuItem eliminarTipo = new ToolStripMenuItem("Eliminar tipo");
                eliminarTipo.Click += EliminarTipo_Click;

                tiposAnalisisMenu.DropDownItems.Add(listarTipos);
                tiposAnalisisMenu.DropDownItems.Add(anadirTipo);
                tiposAnalisisMenu.DropDownItems.Add(modificarTipo);
                tiposAnalisisMenu.DropDownItems.Add(eliminarTipo);
                menuItems["modificarTipo"] = modificarTipo;
                menuItems["eliminarTipo"] = eliminarTipo;
                modificarTipo.Enabled = false;
                eliminarTipo.Enabled = false;

                ToolStripMenuItem localidadesMenu = new ToolStripMenuItem("Localidades");

                ToolStripMenuItem listarLocalidades = new ToolStripMenuItem("Listar localidades");
                listarLocalidades.Click += ListarLocalidades_Click;

                ToolStripMenuItem anadirLocalidad = new ToolStripMenuItem("Añadir localidad");
                anadirLocalidad.Click += AnadirLocalidad_Click;

                ToolStripMenuItem modificarLocalidad = new ToolStripMenuItem("Modificar localidad");
                modificarLocalidad.Click += ModificarLocalidad_Click;

                ToolStripMenuItem eliminarLocalidad = new ToolStripMenuItem("Eliminar localidad");
                eliminarLocalidad.Click += EliminarLocalidad_Click;

                localidadesMenu.DropDownItems.Add(listarLocalidades);
                localidadesMenu.DropDownItems.Add(anadirLocalidad);
                localidadesMenu.DropDownItems.Add(modificarLocalidad);
                localidadesMenu.DropDownItems.Add(eliminarLocalidad);
                menuItems["modificarLocalidad"] = modificarLocalidad;
                menuItems["eliminarLocalidad"] = eliminarLocalidad;
                modificarLocalidad.Enabled = false;
                eliminarLocalidad.Enabled = false;

                ToolStripMenuItem plantillasMenu = new ToolStripMenuItem("Plantillas");

                ToolStripMenuItem listarPlantillas = new ToolStripMenuItem("Listar plantillas");
                listarPlantillas.Click += ListarPlantillas_Click;

                ToolStripMenuItem anadirPlantilla = new ToolStripMenuItem("Añadir plantilla");
                anadirPlantilla.Click += AnadirPlantilla_Click;

                ToolStripMenuItem modificarPlantilla = new ToolStripMenuItem("Modificar plantilla");
                modificarPlantilla.Click += ModificarPlantilla_Click;

                ToolStripMenuItem eliminarPlantilla = new ToolStripMenuItem("Eliminar plantilla");
                eliminarPlantilla.Click += EliminarPlantilla_Click;

                plantillasMenu.DropDownItems.Add(listarPlantillas);
                plantillasMenu.DropDownItems.Add(anadirPlantilla);
                plantillasMenu.DropDownItems.Add(modificarPlantilla);
                plantillasMenu.DropDownItems.Add(eliminarPlantilla);
                menuItems["modificarPlantilla"] = modificarPlantilla;
                menuItems["eliminarPlantilla"] = eliminarPlantilla;
                modificarPlantilla.Enabled = false;
                eliminarPlantilla.Enabled = false;

                pacienteMenuStrip.Items.Add(turnosMenu);
                pacienteMenuStrip.Items.Add(usuariosMenu);
                pacienteMenuStrip.Items.Add(centrosMenu);
                pacienteMenuStrip.Items.Add(tiposAnalisisMenu);
                pacienteMenuStrip.Items.Add(localidadesMenu);
                pacienteMenuStrip.Items.Add(plantillasMenu);

                proximosTurnosAdministradorDGV.Visible = true;
            }
        }

        private void SolicitarTurno_Click(object sender, EventArgs e)
        {
            SolicitarTurno solicitar = new SolicitarTurno(paciente);
            solicitar.ShowDialog();
        }

        private async void CancelarTurno_Click(object sender, EventArgs e)
        {
            if (proximosTurnosPacienteDGV.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar el turno seleccionado?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idABorrar = (int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value;
                    await TurnoApiClient.DeleteAsync(idABorrar);
                    MessageBox.Show("Turno Eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno para poder cancelarlo.");
            }
        }

        private void ModificarDatos_Click(object sender, EventArgs e)
        {
            ModificarDatosPaciente modificarDatos = new ModificarDatosPaciente(paciente);
            modificarDatos.ShowDialog();
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ListarProximosTurnos_Click(object sender, EventArgs e)
        {
            IEnumerable<TurnoDTO> turnos = await TurnoApiClient.GetAllAsync();
            var proximosTurnos = from t in turnos
                         where t.Estado == "Reservado"
                         select t;

            var turnosVista = proximosTurnos.Select(t => new
            {
                t.Id,
                t.Estado,
                t.Receta,
                t.Observaciones,
                t.FechaHoraExtraccion,
                t.FechaHoraReserva,
                t.IdTipoAnalisis,
                t.IdCentroAtencion,
                t.IdPaciente
            }).ToList();

            proximosTurnosAdministradorDGV.DataSource = turnosVista;
            menuItems["eliminarTurno"].Enabled = true;
            proximosTurnosAdministradorDGV.DataSourceChanged += (sender, e) =>
            {
                menuItems["eliminarTurno"].Enabled = false;
            };
        }

        private async void ListarTurnosPendientes_Click(object sender, EventArgs e)
        {
            IEnumerable<TurnoDTO> turnos = await TurnoApiClient.GetAllAsync();
            var turnosPendientes = from t in turnos
                                 where t.Estado == "Pendiente"
                                 select t;
            var turnosVista = turnosPendientes.Select(t => new
            {
                t.Id,
                t.Estado,
                t.FechaHoraExtraccion,
                t.FechaHoraReserva,
                t.IdTipoAnalisis,
                t.IdCentroAtencion,
                t.IdPaciente
            } ).ToList();

            proximosTurnosAdministradorDGV.DataSource = turnosVista;
            menuItems["aceptarTurno"].Enabled = true;
            menuItems["rechazarTurno"].Enabled = true;
            proximosTurnosAdministradorDGV.DataSourceChanged += (sender, e) =>
            {
                menuItems["aceptarTurno"].Enabled = false;
                menuItems["rechazarTurno"].Enabled = false;
            };
        }

        private async void AceptarTurno_Click(object sender, EventArgs e)
        {
            TurnoDTO turnoAAceptar = await TurnoApiClient.GetAsync((int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value);
            TurnoDTO turno = new TurnoDTO
            {
                Id = turnoAAceptar.Id,
                RecibeMail = turnoAAceptar.RecibeMail,
                Estado = turnoAAceptar.Estado,
                Receta = turnoAAceptar.Receta,
                Observaciones = turnoAAceptar.Observaciones,
                FechaHoraExtraccion = turnoAAceptar.FechaHoraExtraccion,
                FechaHoraReserva = turnoAAceptar.FechaHoraReserva,
                IdPaciente = turnoAAceptar.IdPaciente,
                IdTipoAnalisis = turnoAAceptar.IdTipoAnalisis,
                IdCentroAtencion = turnoAAceptar.IdCentroAtencion
            };
            AceptarTurno aceptar = new AceptarTurno(turno);
            aceptar.ShowDialog();
            this.ListarTurnosPendientes_Click(sender, e);
        }

        private async void RechazarTurno_Click(object sender, EventArgs e)
        {
            if (proximosTurnosAdministradorDGV.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea rechazar el turno seleccionado?", "Confirmar rechazo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idABorrar = (int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value;
                    await TurnoApiClient.DeleteAsync(idABorrar);
                    MessageBox.Show("Turno Eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno para poder rechazarlo.");
            }
            this.ListarTurnosPendientes_Click(sender, e);
        }

        private async void EliminarTurno_Click(object sender, EventArgs e)
        {
            if (proximosTurnosAdministradorDGV.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el turno seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idABorrar = (int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value;
                    await TurnoApiClient.DeleteAsync(idABorrar);
                    MessageBox.Show("Turno Eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno para poder eliminarlo.");
            }
        }

        private async void ListarUsuarios_Click(object sender, EventArgs e)
        {
            IEnumerable<PacienteDTO> pacientes = await PacienteApiClient.GetAllAsync();
            var pacientesVista = pacientes.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Apellido,
                p.Dni,
                p.Telefono,
                p.Domicilio,
                p.Email,
                p.FechaNacimiento,
                p.Tipo
            }).ToList();

            proximosTurnosAdministradorDGV.DataSource = pacientesVista;
            menuItems["eliminarUsuario"].Enabled = true;
            proximosTurnosAdministradorDGV.DataSourceChanged += (sender, e) =>
            {
                menuItems["eliminarUsuario"].Enabled = false;
            };
        }

        private async void EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (proximosTurnosAdministradorDGV.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idABorrar = (int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value;
                    await PacienteApiClient.DeleteAsync(idABorrar);
                    MessageBox.Show("Usuario Eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para poder eliminarlo.");
            }
            this.ListarUsuarios_Click(sender, e);
        }

        private async void ListarCentros_Click(object sender, EventArgs e)
        {
            var centros = await CentroAtencionApiClient.GetAllAsync();
            var centrosVista = centros.Select(c => new
            {
                c.Id,
                c.Nombre,
                c.Domicilio,
                c.IdLocalidad,
            }).ToList();
            proximosTurnosAdministradorDGV.DataSource = centrosVista;
            menuItems["modificarCentro"].Enabled = true;
            menuItems["eliminarCentro"].Enabled = true;
            proximosTurnosAdministradorDGV.DataSourceChanged += (sender, e) =>
            {
                menuItems["modificarCentro"].Enabled = false;
                menuItems["eliminarCentro"].Enabled = false;
            };
        }

        private void AnadirCentro_Click(object sender, EventArgs e)
        {
            AgregarCentro agregar = new AgregarCentro();
            agregar.ShowDialog();
            this.ListarCentros_Click(sender, e);
        }

        private async void ModificarCentro_Click(object sender, EventArgs e)
        {
            CentroAtencionDTO centroAModificar = await CentroAtencionApiClient.GetAsync((int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value);
            CentroAtencionDTO centro = new CentroAtencionDTO
            {
                Id = centroAModificar.Id,
                Nombre = centroAModificar.Nombre,
                Domicilio = centroAModificar.Domicilio
            };
            ModificarCentro modificar = new ModificarCentro(centro);
            modificar.ShowDialog();
            this.ListarCentros_Click(sender, e);
        }

        private async void EliminarCentro_Click(object sender, EventArgs e)
        {
            if (proximosTurnosAdministradorDGV.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el centro seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idABorrar = (int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value;
                    await CentroAtencionApiClient.DeleteAsync(idABorrar);
                    MessageBox.Show("Centro eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario para poder eliminarlo.");
                }
            }
            this.ListarCentros_Click(sender, e);
        }

        private async void ListarTipos_Click(object sender, EventArgs e)
        {
            IEnumerable<TipoAnalisisDTO> tipos = await TipoAnalisisApiClient.GetAllAsync();
            var tiposVista = tipos.Select(t => new
            {
                t.Id,
                t.Nombre,
                t.Importe,
                t.IdPlantillaAnalisis
            }).ToList();
            proximosTurnosAdministradorDGV.DataSource = tiposVista;
            menuItems["modificarTipo"].Enabled = true;
            menuItems["eliminarTipo"].Enabled = true;
            proximosTurnosAdministradorDGV.DataSourceChanged += (sender, e) =>
            {
                menuItems["modificarTipo"].Enabled = false;
                menuItems["eliminarTipo"].Enabled = false;
            };
        }

        private void AnadirTipo_Click(object sender, EventArgs e)
        {
            AgregarTipo agregarTipo = new AgregarTipo();
            agregarTipo.ShowDialog();
            this.ListarTipos_Click(sender, e);
        }

        private async void ModificarTipo_Click(object sender, EventArgs e)
        {
            TipoAnalisisDTO tipoAModificar = await TipoAnalisisApiClient.GetAsync((int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value);
            TipoAnalisisDTO tipoAnalisis = new TipoAnalisisDTO
            {
                Id = tipoAModificar.Id,
                Nombre = tipoAModificar.Nombre,
                Importe = tipoAModificar.Importe
            };
            ModificarTipo modificar = new ModificarTipo(tipoAnalisis);
            modificar.ShowDialog();
            this.ListarTipos_Click(sender, e);
        }

        private async void EliminarTipo_Click(object sender, EventArgs e)
        {
            if (proximosTurnosAdministradorDGV.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el tipo de análisis seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idABorrar = (int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value;
                    await TipoAnalisisApiClient.DeleteAsync(idABorrar);
                    MessageBox.Show("Tipo de análisis eliminado exitosamente.");
                    this.ListarTipos_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de análisis para poder eliminarlo.");
            }
        }

        private void proximosTurnosAdministradorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ListarLocalidades_Click(object sender, EventArgs e)
        {
            var localidades = await LocalidadApiClient.GetAllAsync();

            proximosTurnosAdministradorDGV.DataSource = localidades;
            menuItems["modificarLocalidad"].Enabled = true;
            menuItems["eliminarLocalidad"].Enabled = true;

            proximosTurnosAdministradorDGV.DataSourceChanged += (sender2, e2) =>
            {
                menuItems["modificarLocalidad"].Enabled = false;
                menuItems["eliminarLocalidad"].Enabled = false;
            };
        }

        private void AnadirLocalidad_Click(object sender, EventArgs e)
        {
            AgregarLocalidad agregarLocalidad = new AgregarLocalidad();
            agregarLocalidad.ShowDialog();
            this.ListarLocalidades_Click(sender, e);
        }

        private async void ModificarLocalidad_Click(object sender, EventArgs e)
        {
            LocalidadDTO localidadAModificar = await LocalidadApiClient.GetAsync((int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value);
            LocalidadDTO localidad = new LocalidadDTO
            {
                Id = localidadAModificar.Id,
                Nombre = localidadAModificar.Nombre,
                CodigoPostal = localidadAModificar.CodigoPostal
            };
            ModificarLocalidad modificar = new ModificarLocalidad(localidad);
            modificar.ShowDialog();
            this.ListarLocalidades_Click(sender, e);
        }

        private async void EliminarLocalidad_Click(object sender, EventArgs e)
        {
            if (proximosTurnosAdministradorDGV.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la localidad seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idABorrar = (int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value;
                    await LocalidadApiClient.DeleteAsync(idABorrar);
                    MessageBox.Show("Localidad eliminada exitosamente.");
                    this.ListarLocalidades_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una localidad para poder eliminarla.");
            }
        }

        private async void ListarPlantillas_Click(object sender, EventArgs e)
        {
            IEnumerable<PlantillaAnalisisDTO> plantillas = await PlantillaAnalisisApiClient.GetAllAsync();

            proximosTurnosAdministradorDGV.DataSource = plantillas;
            menuItems["modificarPlantilla"].Enabled = true;
            menuItems["eliminarPlantilla"].Enabled = true;

            proximosTurnosAdministradorDGV.DataSourceChanged += (sender2, e2) =>
            {
                menuItems["modificarPlantilla"].Enabled = false;
                menuItems["eliminarPlantilla"].Enabled = false;
            };
        }

        private async void AnadirPlantilla_Click(object sender, EventArgs e)
        {
            AgregarPlantilla agregar = new AgregarPlantilla();
            agregar.ShowDialog();
            this.ListarPlantillas_Click(sender, e);
        }

        private async void ModificarPlantilla_Click(object sender, EventArgs e)
        {
            PlantillaAnalisisDTO plantillaAModificar = await PlantillaAnalisisApiClient.GetAsync((int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value);
            PlantillaAnalisisDTO plantilla = new PlantillaAnalisisDTO
            {
                Id = plantillaAModificar.Id,
                HsAyuno = plantillaAModificar.HsAyuno,
                Preparacion = plantillaAModificar.Preparacion,
                DiasPrevistos = plantillaAModificar.DiasPrevistos
            };
            ModificarPlantilla modificar = new ModificarPlantilla(plantilla);
            modificar.ShowDialog();
            this.ListarPlantillas_Click(sender, e);
        }

        private async void EliminarPlantilla_Click(object sender, EventArgs e)
        {
            if (proximosTurnosAdministradorDGV.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la plantilla seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idABorrar = (int)proximosTurnosAdministradorDGV.CurrentRow.Cells["Id"].Value;
                    await PlantillaAnalisisApiClient.DeleteAsync(idABorrar);
                    MessageBox.Show("Plantilla eliminada exitosamente.");
                    this.ListarPlantillas_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una plantilla para poder eliminarla.");
            }
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "reporte_recepción.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ReporteRecepcion.Generar(sfd.FileName);
                        MessageBox.Show($"Reporte generado en:\n{sfd.FileName}", "Reporte generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir el PDF automáticamente
                        try
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true
                            });
                        }
                        catch
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnGanancias_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "reporte_ganancias.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ReporteGanancias.Generar(sfd.FileName);
                        MessageBox.Show($"Reporte generado en:\n{sfd.FileName}", "Reporte generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Intentar abrir automáticamente
                        try
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true
                            });
                        }
                        catch
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
