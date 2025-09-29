namespace DTOs
{
    public class TurnoDTO
    {
        public int Id { get; set; }
        public bool RecibeMail { get; set; }
        public string? Estado { get; set; }
        public string? Receta { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? FechaHoraExtraccion { get; set; }
        public DateTime FechaHoraReserva { get; set; }
        public int IdPaciente { get; set; }
        public int IdTipoAnalisis { get; set; } 
        public int IdCentroAtencion { get; set; }
    }
}
