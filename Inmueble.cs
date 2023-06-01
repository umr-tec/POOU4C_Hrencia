﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4C_Herencia
{
    class Inmueble
    {
        //Campos
        protected int metrosCuadrados;
        protected string calle, colonia, ciudad,nombreDueno, numeroEscrituras;
        double costo;

        //Constructor

        public Inmueble() { }

        public Inmueble(string nombreDueno, string calle, string colonia, string ciudad, int metrosCuadrados) {
            //Asignar a los campos el valor de los parametros
            this.nombreDueno = nombreDueno;
            this.calle = calle;
            this.colonia = colonia;
            this.ciudad = ciudad;
            this.metrosCuadrados = metrosCuadrados;
        }

        public Inmueble(string nombreDueno, string calle, string colonia, string ciudad, int metrosCuadrados,string numeroEscrituras)
        {
            //Asignar a los campos el valor de los parametros
            this.nombreDueno = nombreDueno;
            this.calle = calle;
            this.colonia = colonia;
            this.ciudad = ciudad;
            this.metrosCuadrados = metrosCuadrados;
            this.numeroEscrituras = numeroEscrituras;
        }
    }
}
