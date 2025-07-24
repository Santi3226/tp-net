namespace DTOs
{
    public class Paciente
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Dni { get; private set; }
        public string Telefono { get; private set; }
        public string Domicilio { get; private set; }
        public string Email { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
    }
}
