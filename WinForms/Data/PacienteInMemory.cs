using Domain.Model;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data
{
    public class PacienteInMemory
    {
        public static List<Paciente> Pacientes;

        static PacienteInMemory()
        {
            Pacientes = new List<Paciente>
            {
                new (1, "Juan", "Pérez","40000000","3400787812","Entre Rios 1300","juan.perez@email.com", new DateTime(2000, 10,1)),
                new (2, "Raul", "Dominguez","43000000","3400612812","San Juan 1230","raul.dominuez@email.com", new DateTime(2001, 9, 8)),
                new (3, "María", "Sosa","41980004","3400787251"," San Luis 970","maria.sosa@email.com", new DateTime(2002, 5, 4)),
                new (4, "Ana", "Martínez","50000000","3521456789","Pte.Roca 2345","ana.martinez@email.com", new DateTime(2010, 01, 09)),
                new (5, "Lucía", "Fernández", "45900879", "3419098743", "Mendoza 3500", "lucia.fernandez@email.com", new DateTime(2004, 9, 3))
            };
        }
    }
}