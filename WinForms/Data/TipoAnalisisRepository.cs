using Domain.Model;
using DTOs;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class TipoAnalisisRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(TipoAnalisis ta)
        {
            using var context = CreateContext();
            context.TiposAnalisis.Add(ta);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var ta = context.TiposAnalisis.Find(id);
            if (ta != null)
            {
                context.TiposAnalisis.Remove(ta);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public TipoAnalisis? Get(int id)
        {
            using var context = CreateContext();
            return context.TiposAnalisis.FirstOrDefault(ta => ta.Id == id);
        }

        public IEnumerable<TipoAnalisis> GetAll()
        {
            using var context = CreateContext();
            return context.TiposAnalisis.ToList();
        }

        public bool Update(TipoAnalisis ta)
        {
            using var context = CreateContext();
            var existingTipo = context.TiposAnalisis.Find(ta.Id);
            if (existingTipo != null)
            {
                existingTipo.SetNombre(ta.Nombre);
                existingTipo.SetImporte(ta.Importe);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
