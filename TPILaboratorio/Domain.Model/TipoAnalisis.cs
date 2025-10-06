namespace Domain.Model
{
    public class TipoAnalisis
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public float Importe { get; private set; }
        public int PlantillaAnalisisId { get; private set; }
        public virtual PlantillaAnalisis PlantillaAnalisis { get; private set; }
        protected TipoAnalisis() { }

        public TipoAnalisis(int id, string nombre, float importe, PlantillaAnalisis plantillaAnalisis)
        {
            SetId(id);
            SetNombre(nombre);
            SetImporte(importe);
            SetPlantillaAnalisis(plantillaAnalisis);
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

        public void SetImporte(float importe)
        {
            if (importe < 0)
                throw new ArgumentException("El importe debe ser positivo.", nameof(importe));
            Importe = importe;
        }
        public void SetPlantillaAnalisis(PlantillaAnalisis plantillaAnalisis)
        {
            if (plantillaAnalisis == null)
                throw new ArgumentNullException(nameof(plantillaAnalisis), "La plantillaAnalisis no puede ser nulo.");

            PlantillaAnalisis = plantillaAnalisis;
            PlantillaAnalisisId = plantillaAnalisis.Id;
        }
    }
}
