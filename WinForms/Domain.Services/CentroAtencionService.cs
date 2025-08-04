using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class CentroAtencionService
    {
        public static CentroAtencion Add(string nombre, string domicilio)
        {
            if (CentroAtencionInMemory.Centros.Any(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un centro de atención con el Nombre '{nombre}'.");
            }
            var id = GetNextId();

            CentroAtencion centroAtencion = new CentroAtencion(id, nombre, domicilio);

            CentroAtencionInMemory.Centros.Add(centroAtencion);

            return centroAtencion;
        }

        public static bool Delete(int id)
        {
            CentroAtencion? centroAtencionToDelete = CentroAtencionInMemory.Centros.Find(c => c.Id == id);

            if (centroAtencionToDelete != null)
            {
                CentroAtencionInMemory.Centros.Remove(centroAtencionToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static CentroAtencionDTO? Get(int id)
        {
            CentroAtencion? centroAtencion = CentroAtencionInMemory.Centros.Find(p => p.Id == id);

            if (centroAtencion == null)
                return null;

            return new CentroAtencionDTO
            {
                Id = centroAtencion.Id,
                Nombre = centroAtencion.Nombre,
                Domicilio = centroAtencion.Domicilio,
            };
        }

        public static IEnumerable<CentroAtencionDTO> GetAll()
        {
            return CentroAtencionInMemory.Centros.Select(centroAtencion => new CentroAtencionDTO
            {
                Id = centroAtencion.Id,
                Nombre = centroAtencion.Nombre,
                Domicilio = centroAtencion.Domicilio,
                }).ToList();
        }

        public static bool Update(int id, string nombre, string domicilio)
        {
            CentroAtencion? centroAtencionToUpdate = CentroAtencionInMemory.Centros.Find(c => c.Id == id);

            if (centroAtencionToUpdate != null)
            {
                if (CentroAtencionInMemory.Centros.Any(c => c.Id != id && c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException($"Ya existe otro centro con el Nombre '{nombre}'.");
                }

                centroAtencionToUpdate.SetNombre(nombre);
                centroAtencionToUpdate.SetDomicilio(domicilio);

                return true;
            }
            else
            {
                return false;
            }
        }
        private static int GetNextId()
        {
            int nextId;

            if (CentroAtencionInMemory.Centros.Count > 0)
            {
                nextId = CentroAtencionInMemory.Centros.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}