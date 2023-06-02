using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4C_Herencia
{
    class Departamento : Inmueble
    {
        //Campos
        byte numeroPisoDepartamento, numeoDepartamento;

        //Heredar constructores
        public Departamento() { }

        public Departamento(byte numeroPisoDepartamento,
            byte numeoDepartamento, string nombreDueno, 
            string calle, string colonia, string ciudad, 
            int metrosCuadrados):base(nombreDueno,calle,colonia,ciudad,metrosCuadrados)
        {
            this.numeoDepartamento = numeoDepartamento;
            this.numeroPisoDepartamento = numeroPisoDepartamento;
        }

        //Metodo detalles
        public override void Detalles()
        {
           
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n \t Módulo de Departamentos");
            Console.WriteLine("El departamento con número: {0}" +
                ", se encuentra en el piso número: {1}.", numeoDepartamento, numeroPisoDepartamento);
            base.Detalles();
        }

    }
}
