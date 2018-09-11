using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesClase07
{
    class Paleta
    {
        private Tempera [] _colores;
        private int _cantidadMaximaElementos;

        public Paleta():this(5)
        {           
               
        }

        public Paleta(int cantidad) 
        {
            this._cantidadMaximaElementos = cantidad;
            this._colores = new Tempera[cantidad];

        }
       
    }
}

//////[]{}