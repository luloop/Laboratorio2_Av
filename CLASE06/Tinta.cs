using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        #region Constructores
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.ConBrillito;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this._tipo = tipo;
        }
        #endregion

        #region Metodos
        public static string Mostrar(Tinta obj)
        {
            if(!Object.Equals(obj,null))
            {
                return obj._Mostrar();
            }
            return "--";
            
        }

        private string _Mostrar()
        {
            return "Color: " + this._color.ToString() + " Tipo: " + this._tipo.ToString();
        }
        #endregion

        #region Sobrecarga operadores
        public static bool operator ==(Tinta a, Tinta b)
        {
            bool retorno = false;
            if(!Object.Equals(a,null) || !Object.Equals(b, null))
            {
                if(a._tipo == b._tipo && a._color == b._color)
                {
                    retorno = true;
                }
            }
            
            return retorno;
        }

        public static bool operator !=(Tinta a, Tinta b)
        {
            return !(a == b);
        }
        #endregion
    }
}
