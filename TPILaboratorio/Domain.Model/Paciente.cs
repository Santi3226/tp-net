using System.Net;
using System.Text.RegularExpressions;

namespace Domain.Model
{
    public class Paciente
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Dni {  get; private set; }
        public string Telefono { get; private set; }
        public string Domicilio { get; private set; }
        public string Email { get; private set; }
        public string Contraseña { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public string Tipo { get; private set; }
        public Paciente(int id, string nombre, string apellido, string dni, string telefono, string domicilio, string email, string contraseña, DateTime fechaNacimiento, string tipo)
        {
            SetId(id);
            SetNombre(nombre);
            SetApellido(apellido);
            SetDni(dni);
            SetTelefono(telefono);
            SetDomicilio(domicilio);
            SetEmail(email);
            SetContraseña(contraseña);
            SetFechaNacimiento(fechaNacimiento);
            SetTipo(tipo);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            Nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido no puede ser nulo o vacío.", nameof(apellido));
            Apellido = apellido;
        }

        public void SetDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El DNI no puede ser nulo o vacío.", nameof(dni));
            Dni = dni;
        }

        public void SetTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El telefono no puede ser nulo o vacío.", nameof(telefono));
            Telefono = telefono;
        }

        public void SetDomicilio(string domicilio)
        {
            if (string.IsNullOrWhiteSpace(domicilio))
                throw new ArgumentException("El domicilio no puede ser nulo o vacío", nameof(domicilio));
            Domicilio = domicilio;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("El mail no puede ser nulo o vacío.", nameof(email));
            Email = email;
        }

        public void SetContraseña(string contraseña)
        {
            if (string.IsNullOrWhiteSpace(contraseña))
                throw new ArgumentException("La contraseña no puede ser vacía", nameof(contraseña));
            Contraseña = contraseña;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            if (fechaNacimiento == default)
                throw new ArgumentException("La fecha de nacimiento no puede ser nula.", nameof(fechaNacimiento));
            FechaNacimiento = fechaNacimiento;
        }

        public void SetTipo(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
                throw new ArgumentException("El tipo no puede ser nulo.", nameof(tipo));
            Tipo = tipo;
        }

    }
}