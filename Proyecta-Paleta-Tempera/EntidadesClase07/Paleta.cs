using System;
using System.Collections.Generic;
using System.Text;


namespace EntidadesClase07
{
    public class Paleta
    {
        #region Atributos
        private Tempera [] _colores;
        private int _cantidadMaximaElementos;

        #endregion

        #region Constructor

        private Paleta():this(5)
        {           
               
        }

        private Paleta(int cantidad) 
        {
            this._cantidadMaximaElementos = cantidad;
            this._colores = new Tempera[this._cantidadMaximaElementos];
        }

        public Tempera this [int indice]
        {
            get
            {
                if (indice >= this._colores.GetLength(0) || indice < 0)
                    return null;
                else
                    return this._colores[indice];
            }
            set
            {
                if (indice >= 0 && indice <= this._colores.GetLength(0))
                    this._colores[indice] = value;

                else if ( indice == this._colores.GetLength(0)) // si el array esta vacio
                {
                    this._colores = this + indice ; // NO ENTIENDO ESTA LINEA
                    this[indice] = value;
                }
                else
                {
                    Console.WriteLine(" no hay lugar");
                    Console.ReadLine();
                }
                    
            }


        }

        #endregion

        #region Metodos

        private string _Mostrar()
        {
            string retorno;
           
            retorno = "Cantidad Maxima: " + this._cantidadMaximaElementos.ToString()+ "\r\n";
            for (int i = 0; i < this._colores.Length; i++)
            {
                if (this._colores.GetValue(i) != null)
                {
                    retorno += this._colores[i] + "\r\n";
                }
            }

            return retorno;
                
             
        }
        #endregion

        #region Sobrecarga operadores

        public static implicit operator Paleta(int cant)
        {
            return new Paleta(cant);
        }

       public static explicit operator string (Paleta paleta)
        {
            return paleta._Mostrar();
        }

        public static bool operator ==(Paleta a, Tempera b)
        {
             bool retorno = false;
          //  if (!Object.Equals(a, null) )
            //{
                for (int i=0; i< a._cantidadMaximaElementos; i++)
                {
                    if ( a._colores.GetValue(i)!=null)
                    {
                         if (a._colores[i]== b)
                        {
                        retorno = true;
                        break;
                        }
                    }
                }
           // }
            return retorno;
        }


        public static bool operator !=(Paleta a, Tempera b)
        {
            return !(a == b);
        }

        public static Paleta operator +(Paleta a, Tempera b)
        {
            if (a==b)
            {
                a._colores[a.ObtenerIndice(b)] += b;
                return a;
            }   
            else 
            {
                int aux = a.ObtenerIndice();
                if( aux!=-1)
                {
                    a._colores[aux] = b;
                }
               
                return a;
            }
                        
        }


        private  int ObtenerIndice()
        {
           int retorno = -1;
           int cant = this._cantidadMaximaElementos;
           for (int i=0; i<cant;i++)
            {
                if (this._colores.GetValue(i) == null)
                 {
                    retorno = i;
                    break;
                 }
            }
            return retorno;
        }

        private int ObtenerIndice(Tempera tempera)
        {
            int retorno = -1;
            int cant = this._cantidadMaximaElementos;
            for (int i = 0; i < cant; i++)
            {
                if (this._colores[i] ==  tempera)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }


        public static Paleta operator -(Paleta a, Tempera b)
        {
            int indice = a.ObtenerIndice(b);
            if (a == b)//a.ObtenerIndice(b)!=-1)
            {
                if (((sbyte)a._colores[indice] - (sbyte)b) <= 0)
                {
                    a._colores[indice] = null;                    
                }

                else
                {
                     a._colores[indice] += (sbyte)((sbyte)b*(-1));                             

                }
                
            }

            return a;
        }

        public static Tempera[] operator +(Paleta paleta, int indice)
        {
            int i = indice >= paleta._colores.GetLength(0) ? ++indice : --indice;// como funciona esto?

            Tempera[] aux = new Tempera[i];
            paleta._colores.CopyTo(aux, 0);

            return aux;

        }

        #endregion

    }
}

//////[]{}