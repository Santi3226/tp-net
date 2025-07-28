using Domain.Model;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data
{
    public class CentroAtencionInMemory
    {
        public static List<CentroAtencion> Centros;

        static CentroAtencionInMemory()
        {
            Centros = new List<CentroAtencion>
            {
                new CentroAtencion(1, "Paseo del Siglo", "Pte. Roca 744"),
                new CentroAtencion(2, "Centro", "Bv. Oroño 200"),
                new CentroAtencion(3, "Damine", "25 de Mayo 1200"),
            };
        }
    }
}
