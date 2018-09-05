using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Pluma
    {
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;

        #region Constructores
        public Pluma()
        {
            this._marca = "Sin marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(int cant):this()
        {
            this._cantidad = cant;
        }

        public Pluma(int cant, string marca):this(cant)
        {
            this._marca = marca;
        }

        public Pluma(int cant, string marca, Tinta tinta):this(cant,marca)
        {
            this._tinta = tinta;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            return "Marca: " + this._marca + " Cantidad: " + this._cantidad.ToString() + " Tinta: " + Tinta.Mostrar(this._tinta);
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }
        #endregion

        #region Sobrecarga operadores

        public static bool operator ==(Pluma a, Tinta b)
        {
            bool retorno = false;
            if(a._tinta == b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Pluma a, Tinta b)
        {
            return !(a._tinta == b);
        }

        public static Pluma operator +(Pluma a, Tinta b)
        {
            if(a == b && a._cantidad < 91)
            {
                a._cantidad += 10;
            }
            else if(a == b && a._cantidad > 90)
            {
                a._cantidad = 100;
            }
            return a;
        }

        public static Pluma operator -(Pluma a, Tinta b)
        {
            if (a == b && a._cantidad >= 10)
            {
                a._cantidad -= 10;
            }
            else if (a == b && a._cantidad < 10)
            {
                a._cantidad = 0;
            }

            return a;
        }
        #endregion
    }
}
