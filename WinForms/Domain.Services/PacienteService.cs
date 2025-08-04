using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class PacienteService
    {
        public static PacienteDTO Add(PacienteDTO dto)
        {
            if (PacienteInMemory.Pacientes.Any(p => p.Email.Equals(dto.Email, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un paciente con el Email '{dto.Email}'.");
            }
            if (PacienteInMemory.Pacientes.Any(p => p.Dni.Equals(dto.Dni, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un paciente con el Dni '{dto.Dni}'.");
            }

            var id = GetNextId();

            Paciente paciente = new Paciente(id, dto.Nombre, dto.Apellido, dto.Email, dto.Telefono, dto.Dni, dto.Domicilio,dto.Contraseña, dto.FechaNacimiento);

            PacienteInMemory.Pacientes.Add(paciente);

            dto.Id = paciente.Id;

            return dto;
        }

        public static bool Delete(int id)
        {
            Paciente? pacienteToDelete = PacienteInMemory.Pacientes.Find(p => p.Id == id);

            if (pacienteToDelete != null)
            {
                PacienteInMemory.Pacientes.Remove(pacienteToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static PacienteDTO? Get(int id)
        {
            Paciente? paciente = PacienteInMemory.Pacientes.Find(p => p.Id == id);

            if (paciente == null)
                return null;

            return new PacienteDTO
            {
                Id = paciente.Id,
                Nombre = paciente.Nombre,
                Apellido = paciente.Apellido,
                Email = paciente.Email,
                Telefono = paciente.Telefono,
                Dni = paciente.Dni,
                Domicilio = paciente.Domicilio,
                FechaNacimiento = paciente.FechaNacimiento
            };
        }

        public static IEnumerable<PacienteDTO> GetAll()
        {
            return PacienteInMemory.Pacientes.Select(paciente => new PacienteDTO
            {
                Id = paciente.Id,
                Nombre = paciente.Nombre,
                Apellido = paciente.Apellido,
                Email = paciente.Email,
                Telefono = paciente.Telefono,
                Dni = paciente.Dni,
                Domicilio = paciente.Domicilio,
                FechaNacimiento = paciente.FechaNacimiento
            }).ToList();
        }

        public static bool Update(PacienteDTO dto)
        {
            Paciente? pacienteToUpdate = PacienteInMemory.Pacientes.Find(p => p.Id == dto.Id);

            if (pacienteToUpdate != null)
            {
                if (PacienteInMemory.Pacientes.Any(p => p.Id != dto.Id && p.Email.Equals(dto.Email, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException($"Ya existe otro paciente con el Email '{dto.Email}'.");
                }
                if (PacienteInMemory.Pacientes.Any(p => p.Id != dto.Id && p.Dni.Equals(dto.Dni, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException($"Ya existe otro paciente con el Dni '{dto.Dni}'.");
                }

                pacienteToUpdate.SetNombre(dto.Nombre);
                pacienteToUpdate.SetApellido(dto.Apellido);
                pacienteToUpdate.SetEmail(dto.Email);

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

            if (PacienteInMemory.Pacientes.Count > 0)
            {
                nextId = PacienteInMemory.Pacientes.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}