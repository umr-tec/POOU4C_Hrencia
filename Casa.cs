using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4C_Herencia
{
    class Casa : Inmueble
    {
        string metrosPatio;
        //Herencia de constructotres
        public Casa() { }
        public Casa(string metrosPatio,string nombreDueno, string calle, string colonia, string ciudad, int metrosCuadrados)
            :base(nombreDueno,calle,colonia,ciudad,metrosCuadrados)
        {
            this.metrosPatio = metrosPatio;
        }

        public Casa(string nombreDueno, string calle, string colonia, string ciudad, int metrosCuadrados, string numeroEscrituras)
            : base(nombreDueno, calle, colonia, ciudad, metrosCuadrados,numeroEscrituras)
        {

        }
    }
}
