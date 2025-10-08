namespace Domain.Model
{
    public class CentroAtencion
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Domicilio { get; private set; }
        public int LocalidadId { get; private set; }
        public virtual Localidad Localidad { get; private set; }

        public CentroAtencion() { }

        public CentroAtencion(int id, string nombre, string domicilio, Localidad localidad)
        {
            SetId(id);
            SetNombre(nombre);
            SetDomicilio(domicilio);
            SetLocalidad(localidad);
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

        public void SetDomicilio(string domicilio)
        {
            if (string.IsNullOrWhiteSpace(domicilio))
                throw new ArgumentException("El domicilio no puede ser nulo o vacío.", nameof(domicilio));
            Domicilio = domicilio;
        }

        public void SetLocalidad(Localidad localidad)
        {
            if (localidad == null)
                throw new ArgumentNullException(nameof(localidad), "La localidad no puede ser nula.");

            Localidad = localidad;
            LocalidadId = localidad.Id;
        }
    }
}