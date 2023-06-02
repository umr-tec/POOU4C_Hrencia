using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4C_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia
            Inmueble objeto1 = new Inmueble();
            //Intancia
            Casa objeto2 = new Casa("Sergio Servando", "Del Rio", "Frondoso", "New York", 765, "qw345tygdfdwtegr");
            Departamento objeto3 = new Departamento(3, 12, "Héctor Miguel", "De los Pinos", "Sendas del Bosque", "Torreón", 456);
            objeto3.Detalles();
            objeto2.Detalles();
            

            Console.ReadKey();
        }
    }
}
