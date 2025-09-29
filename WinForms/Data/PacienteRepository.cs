using Domain.Model;
using DTOs;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class PacienteRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Paciente p)
        {
            using var context = CreateContext();
            context.Pacientes.Add(p);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var p = context.Pacientes.Find(id);
            if (p!= null)
            {
                context.Pacientes.Remove(p);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Paciente? Get(int id)
        {
            using var context = CreateContext();
            return context.Pacientes.Find(id);
        }

        public IEnumerable<Paciente> GetAll()
        {
            using var context = CreateContext();
            return context.Pacientes.ToList();
        }

        public bool Update(Paciente p)
        {
            using var context = CreateContext();
            var existingPaciente = context.Pacientes.Find(p.Id);
            if (existingPaciente != null)
            {
                existingPaciente.SetNombre(p.Nombre);
                existingPaciente.SetApellido(p.Apellido);
                existingPaciente.SetEmail(p.Email);
                existingPaciente.SetDomicilio(p.Domicilio);
                existingPaciente.SetContraseña(p.Contraseña);
                existingPaciente.SetDni(p.Dni);
                existingPaciente.SetTelefono(p.Telefono);
                existingPaciente.SetFechaNacimiento(p.FechaNacimiento);
                existingPaciente.SetTipo(p.Tipo);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EmailExists(string email, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Pacientes.Where(c => c.Email.ToLower() == email.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            return query.Any();
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