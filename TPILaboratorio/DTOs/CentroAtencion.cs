namespace DTOs
{
    public class CentroAtencionDTO
    {
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Domicilio { get; set; }
        public string Text { get; }
        public int IdLocalidad { get; set; }
    }
}
