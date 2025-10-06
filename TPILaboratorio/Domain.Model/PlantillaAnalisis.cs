namespace Domain.Model
{
    public class PlantillaAnalisis
    {
        public int Id { get; private set; }
        public string HsAyuno { get; private set; }
        public string Preparacion { get; private set; }
        public int DiasPrevistos { get; private set; }
        protected PlantillaAnalisis() { }

        public PlantillaAnalisis(int id, string hsAyuno, string preparacion, int diasPrevistos)
        {
            SetId(id);
            SetHsAyuno(hsAyuno);
            SetPreparacion(preparacion);
            SetDiasPrevistos(diasPrevistos);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }

        public void SetHsAyuno(string hsAyuno)
        {
            if (string.IsNullOrWhiteSpace(hsAyuno))
                throw new ArgumentException("Las hs de ayuno no puede ser nulo o vacío.", nameof(hsAyuno));
            HsAyuno = hsAyuno;
        }

        public void SetPreparacion(string preparacion)
        {
            if (string.IsNullOrWhiteSpace(preparacion))
                throw new ArgumentException("La preparacion no puede ser nulo o vacío.", nameof(preparacion));
            Preparacion = preparacion;
        }

        public void SetDiasPrevistos(int diasPrevistos)
        {
            if (diasPrevistos < 0)
                throw new ArgumentException("Los dias previstos deben ser mayor que 0.", nameof(diasPrevistos));
            DiasPrevistos = diasPrevistos;
        }
    }
}
