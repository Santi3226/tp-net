using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class PacienteService
    {
        public static Paciente Add(string nombre, string apellido, string dni, string telefono, string domicilio, string email, string contraseña, DateTime fechaNacimiento)
        {
            if (PacienteInMemory.Pacientes.Any(p => p.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un paciente con el Email '{email}'.");
            }
            if (PacienteInMemory.Pacientes.Any(p => p.Dni.Equals(dni, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un paciente con el Dni '{dni}'.");
            }

            var id = GetNextId();

            Paciente paciente = new Paciente(id, nombre, apellido, dni, telefono, domicilio, email, contraseña, fechaNacimiento);

            PacienteInMemory.Pacientes.Add(paciente);

            return paciente;
        }

        public bool Delete(int id)
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

        public PacienteDTO? Get(int id)
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

        public IEnumerable<PacienteDTO> GetAll()
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

        public bool Update(PacienteDTO dto)
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