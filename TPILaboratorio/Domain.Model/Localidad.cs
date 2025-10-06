namespace Domain.Model
{
    public class Localidad
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string CodigoPostal { get; private set; }

        protected Localidad() { }

        public Localidad(int id, string nombre, string codigoPostal)
        {
            SetId(id);
            SetNombre(nombre);
            SetCodigoPostal(codigoPostal);
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

        public void SetCodigoPostal(string codigoPostal)
        {
            if (string.IsNullOrWhiteSpace(codigoPostal))
                throw new ArgumentException("El código postal no puede ser nulo o vacío.", nameof(codigoPostal));
            CodigoPostal = codigoPostal;
        }
    }
}
