using Domain.Model;
using Data;
using DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace Application.Services
{
    public class PacienteService
    {
        public PacienteDTO Add(PacienteDTO dto)
        {
            var pacienteRepository = new PacienteRepository();

            // Validar que el email no esté duplicado
            if (pacienteRepository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un cliente con el Email '{dto.Email}'.");
            }
            Paciente paciente = new Paciente(0, dto.Nombre, dto.Apellido, dto.Dni, 
            dto.Telefono, dto.Domicilio, dto.Email, dto.Contraseña, dto.FechaNacimiento, dto.Tipo);
            pacienteRepository.Add(paciente);

            dto.Id = paciente.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var pacienteRepository = new PacienteRepository();
            return pacienteRepository.Delete(id);
        }

        public PacienteDTO Get(int id)
        {
            var pacienteRepository = new PacienteRepository();
            Paciente? p = pacienteRepository.Get(id);

            if (p == null)
                return null;

            return new PacienteDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Email = p.Email,
                Telefono = p.Telefono,
                Domicilio = p.Domicilio,
                Dni = p.Dni,
                Contraseña = p.Contraseña,
                FechaNacimiento = p.FechaNacimiento,
                Tipo = p.Tipo
            };
        }

        public IEnumerable<PacienteDTO> GetAll()
        {
            var pacienteRepository = new PacienteRepository();
            return pacienteRepository.GetAll().Select(p => new PacienteDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Email = p.Email,
                Telefono = p.Telefono,
                Domicilio = p.Domicilio,
                Dni = p.Dni,
                Contraseña = p.Contraseña,
                FechaNacimiento = p.FechaNacimiento,
                Tipo = p.Tipo
            }).ToList();
        }

        public bool Update(PacienteDTO dto)
        {
            var pacienteRepository = new PacienteRepository();

            // Validar que el email no esté duplicado (excluyendo el cliente actual)
            if (pacienteRepository.EmailExists(dto.Email, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro cliente con el Email '{dto.Email}'.");
            }

            Paciente paciente = new Paciente(dto.Id, dto.Nombre, dto.Apellido, dto.Dni,
            dto.Telefono, dto.Domicilio, dto.Email, dto.Contraseña, dto.FechaNacimiento, dto.Tipo);
            return pacienteRepository.Update(paciente);
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