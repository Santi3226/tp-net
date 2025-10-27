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
            context.PlantillasAnalisis.Attach(ta.PlantillaAnalisis);
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
            return context.TiposAnalisis.Include(ta => ta.PlantillaAnalisis). 
                FirstOrDefault(ta => ta.Id == id);
        }

        public IEnumerable<TipoAnalisis> GetAll()
        {
            using var context = CreateContext();
            return context.TiposAnalisis.Include(ta => ta.PlantillaAnalisis).ToList();
        }

        public bool Update(TipoAnalisis ta)
        {
            using var context = CreateContext();
            var existingTipo = context.TiposAnalisis.Find(ta.Id);
            if (existingTipo != null)
            {
                context.PlantillasAnalisis.Attach(ta.PlantillaAnalisis);
                existingTipo.SetNombre(ta.Nombre);
                existingTipo.SetImporte(ta.Importe);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
