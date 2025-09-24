namespace Domain.Model
{
    public class Turno
    {
        public int Id { get; private set; }
        public bool RecibeMail { get; private set; }
        public string Estado { get; private set; }
        public string Receta { get; private set; }
        public string Observaciones { get; private set; }
        public DateTime? FechaHoraExtraccion { get; private set; }
        public DateTime FechaHoraReserva { get; private set; }
        public int PacienteId { get; private set; }
        public virtual Paciente Paciente { get; private set; }

        protected Turno() { }

        public Turno(int id, bool recibeMail, string estado, string receta, string observaciones, DateTime fechaHoraReserva, Paciente paciente)
        {
            SetId(id);
            SetRecibeMail(recibeMail);
            SetReceta(receta);
            SetEstado(estado);
            SetObservaciones(observaciones);
            SetFechaHoraReserva(fechaHoraReserva);
            SetPaciente(paciente);
        }
        public Turno(int id, bool recibeMail, string estado, string receta, string observaciones, DateTime fechaHoraReserva, DateTime? fechaHoraExtraccion, Paciente paciente)
        {
            SetId(id);
            SetRecibeMail(recibeMail);
            SetReceta(receta);
            SetEstado(estado);
            SetObservaciones(observaciones);
            SetFechaHoraReserva(fechaHoraReserva);
            SetFechaHoraExtraccion(fechaHoraExtraccion);
            SetPaciente(paciente);
        }
        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }
        public void SetEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                throw new ArgumentException("El estado no puede ser nulo o vacío.", nameof(estado));
            Estado = estado;
        }
        public void SetReceta(string receta)
        {
            if (string.IsNullOrWhiteSpace(receta))
                throw new ArgumentException("La receta no puede ser nulo o vacío.", nameof(receta));
            Receta = receta;
        }
        public void SetPaciente(Paciente paciente)
        {
            if (paciente == null)
                throw new ArgumentNullException(nameof(paciente), "El paciente no puede ser nulo.");

            Paciente = paciente;
            PacienteId = paciente.Id;
        }
        public void SetRecibeMail(bool rm)
        {
            RecibeMail = rm;
        }
        public void SetObservaciones(string obs)
        {
            if (string.IsNullOrWhiteSpace(obs))
                Observaciones = "-";
            Observaciones = obs;
        }
        public void SetFechaHoraReserva(DateTime fhe)
        {
            if (fhe == default)
                throw new ArgumentException("La fecha de reserva no puede ser nula.", nameof(fhe));
            FechaHoraReserva = fhe;
        }
        public void SetFechaHoraExtraccion(DateTime? fhe)
        {
            FechaHoraExtraccion = fhe;
        }
    }
}