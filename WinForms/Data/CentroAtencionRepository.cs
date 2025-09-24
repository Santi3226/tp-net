using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class CentroRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(CentroAtencion c)
        {
            using var context = CreateContext();
            context.Centros.Add(c);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var c = context.Centros.Find(id);
            if (c!= null)
            {
                context.Centros.Remove(c);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public CentroAtencion? Get(int id)
        {
            using var context = CreateContext();
            return context.Centros.Find(id);
        }

        public IEnumerable<CentroAtencion> GetAll()
        {
            using var context = CreateContext();
            return context.Centros.ToList();
        }

        public bool Update(CentroAtencion c)
        {
            using var context = CreateContext();
            var existingCentro = context.Centros.Find(c.Id);
            if (existingCentro != null)
            {
                existingCentro.SetNombre(c.Nombre);
                existingCentro.SetDomicilio(c.Domicilio);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool NombreExists(string nombre, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Centros.Where(c => c.Nombre.ToLower() == nombre.ToLower());
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