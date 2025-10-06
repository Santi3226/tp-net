using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class LocalidadService
    {
        public LocalidadDTO Add(LocalidadDTO dto)
        {
            var localidadRepository = new LocalidadRepository();
            Localidad localidad = new Localidad(0, dto.Nombre, dto.CodigoPostal);
            localidadRepository.Add(localidad);
            dto.Id = localidad.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var localidadRepository = new LocalidadRepository();
            return localidadRepository.Delete(id);
        }

        public LocalidadDTO Get(int id)
        {
            var localidadRepository = new LocalidadRepository();
            Localidad? l = localidadRepository.Get(id);

            if (l == null)
                return null;

            return new LocalidadDTO
            {
                Id = l.Id,
                Nombre = l.Nombre,
                CodigoPostal = l.CodigoPostal,
            };
        }

        public IEnumerable<LocalidadDTO> GetAll()
        {
            var localidadRepository = new LocalidadRepository();
            return localidadRepository.GetAll().Select(l => new LocalidadDTO
            {
                Id = l.Id,
                Nombre = l.Nombre,
                CodigoPostal = l.CodigoPostal,
            }).ToList();
        }

        public bool Update(LocalidadDTO dto)
        {
            var localidadRepository = new LocalidadRepository();
            Localidad localidad = new Localidad((int)dto.Id, dto.Nombre, dto.CodigoPostal);
            return localidadRepository.Update(localidad);
        }
    }
}
