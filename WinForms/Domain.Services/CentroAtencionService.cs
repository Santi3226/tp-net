using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class CentroAtencionService
    {
        public CentroAtencionDTO Add(CentroAtencionDTO dto)
        {
            if (CentroAtencionInMemory.Centros.Any(c => c.Nombre.Equals(dto.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un centro de atención con el Nombre '{dto.Nombre}'.");
            }
            var id = GetNextId();

            CentroAtencion centroAtencion = new CentroAtencion(id, dto.Nombre, dto.Domicilio);

            CentroAtencionInMemory.Centros.Add(centroAtencion);

            dto.Id = centroAtencion.Id;

            return dto;
        }

        public bool Delete(int id)
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

        public CentroAtencionDTO Get(int id)
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

        public IEnumerable<CentroAtencionDTO> GetAll()
        {
            return CentroAtencionInMemory.Centros.Select(centroAtencion => new CentroAtencionDTO
            {
                Id = centroAtencion.Id,
                Nombre = centroAtencion.Nombre,
                Domicilio = centroAtencion.Domicilio,
                }).ToList();
        }

        public bool Update(CentroAtencionDTO dto)
        {
            CentroAtencion? centroAtencionToUpdate = CentroAtencionInMemory.Centros.Find(c => c.Id == dto.Id);

            if (centroAtencionToUpdate != null)
            {
                if (CentroAtencionInMemory.Centros.Any(c => c.Id != dto.Id && c.Nombre.Equals(dto.Nombre, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException($"Ya existe otro paciente con el Email '{dto.Nombre}'.");
                }

                centroAtencionToUpdate.SetNombre(dto.Nombre);
                centroAtencionToUpdate.SetDomicilio(dto.Domicilio);

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