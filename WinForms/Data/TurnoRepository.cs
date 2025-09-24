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
            return context.Turnos.Find(id);
        }

        public IEnumerable<Turno> GetAll()
        {
            using var context = CreateContext();
            return context.Turnos.ToList();
        }

        public bool Update(Turno t)
        {
            using var context = CreateContext();
            var existingTurno = context.Turnos.Find(t.Id);
            if (existingTurno != null)
            {
                existingTurno.SetReceta(t.Receta);
                existingTurno.SetEstado(t.Estado);
                existingTurno.SetRecibeMail(t.RecibeMail);
                existingTurno.SetReceta(t.Receta);
                existingTurno.SetFechaHoraReserva(t.FechaHoraReserva);
                existingTurno.SetFechaHoraExtraccion(t.FechaHoraExtraccion);
                existingTurno.SetPaciente(t.Pacient);
                context.SaveChanges();
                return true;
            }
            return false;
        }

/*
        public IEnumerable<Paciente> GetByCriteria(ClienteCriteria criteria)
        {
            const string sql = @"
                SELECT Id, Nombre, Apellido, Email, FechaAlta 
                FROM Clientes 
                WHERE Nombre LIKE @SearchTerm 
                   OR Apellido LIKE @SearchTerm 
                   OR Email LIKE @SearchTerm
                ORDER BY Nombre, Apellido";

            var clientes = new List<Cliente>();
            string connectionString = new TPIContext().Database.GetConnectionString();
            string searchPattern = $"%{criteria.Texto}%";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection);
            
            command.Parameters.AddWithValue("@SearchTerm", searchPattern);

            connection.Open();
            using var reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                var cliente = new Cliente(
                    reader.GetInt32(0),    // Id
                    reader.GetString(1),   // Nombre
                    reader.GetString(2),   // Apellido
                    reader.GetString(3),   // Email
                    reader.GetDateTime(4)  // FechaAlta
                );
                
                clientes.Add(cliente);
            }

            return clientes;
        }

    */}
}