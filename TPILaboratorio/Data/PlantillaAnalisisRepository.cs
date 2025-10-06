using Domain.Model;
using DTOs;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class PlantillaAnalisisRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(PlantillaAnalisis pa)
        {
            using var context = CreateContext();
            context.PlantillasAnalisis.Add(pa);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var pa = context.PlantillasAnalisis.Find(id);
            if (pa != null)
            {
                context.PlantillasAnalisis.Remove(pa);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public PlantillaAnalisis? Get(int id)
        {
            using var context = CreateContext();
            return context.PlantillasAnalisis.FirstOrDefault(ta => ta.Id == id);
        }

        public IEnumerable<PlantillaAnalisis> GetAll()
        {
            using var context = CreateContext();
            return context.PlantillasAnalisis.ToList();
        }

        public bool Update(PlantillaAnalisis ta)
        {
            using var context = CreateContext();
            var existingTipo = context.PlantillasAnalisis.Find(ta.Id);
            if (existingTipo != null)
            {
                existingTipo.SetHsAyuno(ta.HsAyuno);
                existingTipo.SetPreparacion(ta.Preparacion);
                existingTipo.SetDiasPrevistos(ta.DiasPrevistos);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
