using Domain.Model;
using DTOs;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class TurnoRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Turno t)
        {
            using var context = CreateContext();
            context.Pacientes.Attach(t.Paciente);//Importante para q se guarde bien el paciente
            context.TiposAnalisis.Attach(t.TipoAnalisis);
            context.Centros.Attach(t.CentroAtencion);
            context.Turnos.Add(t);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var t = context.Turnos.Find(id);
            if (t!= null)
            {
                context.Turnos.Remove(t);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Turno? Get(int id)
        {
            using var context = CreateContext();
            return context.Turnos
                              .Include(t => t.Paciente)  // Esto los vincula
                              .Include(t => t.TipoAnalisis)
                              .Include(t => t.CentroAtencion)
                              .FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Turno> GetAll()
        {
            using var context = CreateContext();
            return context.Turnos.Include(t => t.Paciente).Include(t => t.TipoAnalisis).Include(t => t.CentroAtencion).ToList();
        }

        public bool Update(Turno t)
        {
            using var context = CreateContext();
            var existingTurno = context.Turnos.Find(t.Id);
            if (existingTurno != null)
            {
                context.Pacientes.Attach(t.Paciente);
                context.TiposAnalisis.Attach(t.TipoAnalisis);
                context.Centros.Attach(t.CentroAtencion);
                existingTurno.SetReceta(t.Receta);
                existingTurno.SetEstado(t.Estado);
                existingTurno.SetRecibeMail(t.RecibeMail);
                existingTurno.SetObservaciones(t.Observaciones);
                existingTurno.SetFechaHoraReserva(t.FechaHoraReserva);
                existingTurno.SetFechaHoraExtraccion(t.FechaHoraExtraccion);
                existingTurno.SetPaciente(t.Paciente);
                existingTurno.SetTipoAnalisis(t.TipoAnalisis);
                existingTurno.SetCentroAtencion(t.CentroAtencion);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Turno> GetByPacienteId(int pacienteId)
        {
            using var context = CreateContext();
            List<Turno> turnosDelPaciente = new List<Turno>();
            var turnos = from t in context.Turnos.Include(t => t.TipoAnalisis).Include(t => t.Paciente).Include(t => t.CentroAtencion)
                         where t.PacienteId == pacienteId
                         select t;
            foreach(Turno t in turnos)
            {
                turnosDelPaciente.Add(t);
            }
            return turnosDelPaciente;
        }

        public List<Turno> GetReservados()
        {
            using var context = CreateContext();
            List<Turno> turnosProximos = new List<Turno>();
            var turnos = from t in context.Turnos.Include(t => t.TipoAnalisis).Include(t => t.Paciente)
                         where t.Estado == "Reservado" 
                         select t;
            foreach (Turno t in turnos)
            {
                turnosProximos.Add(t);
            }
            return turnosProximos;
        }

        public List<Turno> GetPendientes()
        {
            using var context = CreateContext();
            List<Turno> turnosProximos = new List<Turno>();
            var turnos = from t in context.Turnos.Include(t => t.TipoAnalisis).Include(t => t.Paciente)
                         where t.Estado == "Pendiente"
                         select t;
            foreach (Turno t in turnos)
            {
                turnosProximos.Add(t);
            }
            return turnosProximos;
        }

        public IEnumerable<Turno> GetByADO()
        {
            const string sql = @"SELECT 
            t.Id AS TurnoId, t.RecibeMail, t.Estado, t.Receta, t.Observaciones, t.FechaHoraReserva, t.FechaHoraExtraccion,
            p.Id AS PacienteId, p.Nombre AS PacienteNombre, p.Apellido AS PacienteApellido, p.Dni AS PacienteDni, p.Telefono AS 
            PacienteTelefono, p.Domicilio AS PacienteDomicilio, p.Email AS PacienteEmail, p.Contraseña AS PacienteContraseña, 
            p.FechaNacimiento AS PacienteFechaNacimiento, p.Tipo AS PacienteTipo,
            ta.Id AS TipoAnalisisId, ta.Nombre AS TipoAnalisisNombre, ta.Importe AS TipoAnalisisImporte, ta.PlantillaAnalisisId AS TipoAnalisisPlantillaId,
            ca.Id AS CentroAtencionId,ca.Nombre AS CentroAtencionNombre, ca.Domicilio AS CentroAtencionDomicilio,ca.LocalidadId AS CentroAtencionLocalidadId

            FROM dbo.Turnos t
            INNER JOIN dbo.Pacientes p ON t.PacienteId = p.Id
            INNER JOIN dbo.TiposAnalisis ta ON t.TipoAnalisisId = ta.Id
            INNER JOIN dbo.Centros ca ON t.CentroAtencionId = ca.Id
            ORDER BY t.Id;";

			var turnos = new List<Turno>();
			string connectionString = new TPIContext().Database.GetConnectionString();

			using var connection = new SqlConnection(connectionString);
			using var command = new SqlCommand(sql, connection);
			connection.Open();
			using var reader = command.ExecuteReader();

			while (reader.Read())
			{
				// PACIENTE
				var paciente = new Paciente(
					reader.GetInt32(reader.GetOrdinal("PacienteId")),
					reader.GetString(reader.GetOrdinal("PacienteNombre")),
					reader.GetString(reader.GetOrdinal("PacienteApellido")),
					reader.GetString(reader.GetOrdinal("PacienteDni")),
					reader.GetString(reader.GetOrdinal("PacienteTelefono")),
					reader.GetString(reader.GetOrdinal("PacienteDomicilio")),
					reader.GetString(reader.GetOrdinal("PacienteEmail")),
					reader.GetString(reader.GetOrdinal("PacienteContraseña")),
					reader.GetDateTime(reader.GetOrdinal("PacienteFechaNacimiento")),
					reader.GetString(reader.GetOrdinal("PacienteTipo"))
				);

				// TIPO ANALISIS
				var tipoAnalisis = new TipoAnalisis(
	                reader.GetInt32(reader.GetOrdinal("TipoAnalisisId")),
	                reader.GetString(reader.GetOrdinal("TipoAnalisisNombre")),
	                (float)reader.GetDouble(reader.GetOrdinal("TipoAnalisisImporte"))
                );

				var centroAtencion = new CentroAtencion(
					reader.GetInt32(reader.GetOrdinal("CentroAtencionId")),
					reader.GetString(reader.GetOrdinal("CentroAtencionNombre")),
					reader.GetString(reader.GetOrdinal("CentroAtencionDomicilio"))
				);

				// TURNO
				var turno = new Turno(
					reader.GetInt32(reader.GetOrdinal("TurnoId")),
					reader.GetBoolean(reader.GetOrdinal("RecibeMail")),
					reader.GetString(reader.GetOrdinal("Estado")),
					reader.IsDBNull(reader.GetOrdinal("Receta")) ? null : reader.GetString(reader.GetOrdinal("Receta")),
					reader.IsDBNull(reader.GetOrdinal("Observaciones")) ? null : reader.GetString(reader.GetOrdinal("Observaciones")),
					reader.GetDateTime(reader.GetOrdinal("FechaHoraReserva")),
					reader.IsDBNull(reader.GetOrdinal("FechaHoraExtraccion"))
						? (DateTime?)null
						: reader.GetDateTime(reader.GetOrdinal("FechaHoraExtraccion")),
					paciente,
					tipoAnalisis,
					centroAtencion
				);

				turnos.Add(turno);
			}

			return turnos;
		}
	}
}