using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase07
{
    public class Tempera
    {
        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;

        #region Constructores
        
        public Tempera(sbyte cant, ConsoleColor color, string marca) 
        {
            this._cantidad = cant;
            this._color = color;
            this._marca= marca;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            return "Cantidad: " + this._cantidad.ToString() + " Color: " + this._color.ToString() + " Marca " + this._marca;
        }

        #endregion

        #region Sobrecarga operadores

        public static implicit operator string (Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static explicit operator sbyte(Tempera tempera)
        {
            return tempera._cantidad;
        }

        public static bool operator ==(Tempera a, Tempera b)
         
        {
            bool retorno = false;
            if (a._color == b._color && a._marca == b._marca)
            {
                retorno = true;
            }
            return retorno;
        }
                  

        public static bool operator !=(Tempera a, Tempera b)
        {
            return !(a._color == b._color && a._marca == b._marca);
        }

        public static Tempera operator +(Tempera a, sbyte b)
        {
            if (a._cantidad >=0  && b >= 0 && a !=null)
            {
                a._cantidad +=b;
            }
            
            return a;
        }

        public static Tempera operator +(Tempera a, Tempera b)
        {
            Tempera aux = new Tempera(a._cantidad, a._color, a._marca);

            if (a==b)
            {
                aux = a;
                aux._cantidad += b._cantidad;
            }

            return aux;
        }
         /*
        public static Tempera operator -(Tempera a, Tempera b)
        {
            Tempera aux = new Tempera(a._cantidad, a._color, a._marca);

            if (a == b)
            {
                aux = a;
                aux._cantidad -= b._cantidad;
            }

            return aux;
        }

    */


        #endregion

    }
}
