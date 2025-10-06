using Domain.Model;

namespace Data
{
    public class LocalidadRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Localidad l)
        {
            using var context = CreateContext();
            context.Localidades.Add(l);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var l = context.Localidades.Find(id);
            if (l != null)
            {
                context.Localidades.Remove(l);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Localidad? Get(int id)
        {
            using var context = CreateContext();
            return context.Localidades.Find(id);
        }

        public IEnumerable<Localidad> GetAll()
        {
            using var context = CreateContext();
            return context.Localidades.ToList();
        }

        public bool Update(Localidad l)
        {
            using var context = CreateContext();
            var existingLocalidad = context.Localidades.Find(l.Id);
            if (existingLocalidad != null)
            {
                existingLocalidad.SetNombre(l.Nombre);
                existingLocalidad.SetCodigoPostal(l.CodigoPostal);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
