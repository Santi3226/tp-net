namespace DTOs
{
    public class PacienteDTO
    {

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Dni { get; set; }
        public string? Telefono { get; set; }
        public string? Domicilio { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
