using Domain.Model;
using Data;
using DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Xml;

namespace Application.Services
{
    public class CentroAtencionService
    {
        public CentroAtencionDTO Add(CentroAtencionDTO dto)
        {
            var centroRepository = new CentroRepository();

            // Validar que el nombre no esté duplicado
            if (centroRepository.NombreExists(dto.Nombre))
            {
                throw new ArgumentException($"Ya existe un centro de atención con el Nombre '{dto.Nombre}'.");
            }
            CentroAtencion centro = new CentroAtencion(0, dto.Nombre, dto.Domicilio);
            centroRepository.Add(centro);

            dto.Id = centro.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var centroRepository = new CentroRepository();
            return centroRepository.Delete(id);
        }

        public CentroAtencionDTO Get(int id)
        {
            var centroRepository = new CentroRepository();
            CentroAtencion? c = centroRepository.Get(id);

            if (c == null)
                return null;

            return new CentroAtencionDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Domicilio = c.Domicilio,
            };
        }

        public IEnumerable<CentroAtencionDTO> GetAll()
        {
            var centroRepository = new CentroRepository();
            return centroRepository.GetAll().Select(c => new CentroAtencionDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Domicilio = c.Domicilio,
            }).ToList();
        }

        public bool Update(CentroAtencionDTO dto)
        {
            var centroRepository = new CentroRepository();

            // Validar que el email no esté duplicado (excluyendo el cliente actual)
            if (centroRepository.NombreExists(dto.Nombre, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro centro de atención con el Nombre '{dto.Nombre}'.");
            }
            CentroAtencion centro = new CentroAtencion((int)dto.Id, dto.Nombre, dto.Domicilio);
            return centroRepository.Update(centro);
        }
        /*
        public IEnumerable<PacienteDTO> GetByCriteria(ClienteCriteriaDTO criteriaDTO)
        {
            var clienteRepository = new ClienteRepository();

            // Mapear DTO a Domain Model
            var criteria = new ClienteCriteria(criteriaDTO.Texto);

            // Llamar al repositorio
            var clientes = clienteRepository.GetByCriteria(criteria);

            // Mapear Domain Model a DTO
            return clientes.Select(c => new ClienteDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Email = c.Email,
                FechaAlta = c.FechaAlta
            });
        }*/
    }
}