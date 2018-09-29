using System;
using System.Collections.Generic;
using System.Text;



namespace EntidadesClase07
{
    public class PaletaColecciones
    {
        #region Atributos
        private List<Tempera> _colores;
        private int _cantidadMaximaElementos;

        #endregion

        #region Constructor

        private PaletaColecciones() : this(5)
        {

        }

        private PaletaColecciones(int cantidad)
        {
            this._cantidadMaximaElementos = cantidad;
            this._colores = new List<Tempera>();
        }

        public Tempera this[int indice]
        {
            get
            {
                if (indice >= this._colores.Count || indice < 0)
                    return null;
                else
                    return this._colores[indice];
            }
            set
            {
                if (indice >= 0 && indice <= this._colores.Count)
                    this._colores.Add(value);

                else if (indice == this._colores.Count) // si el array esta vacio
                {

                    this._colores.Add(value);
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

            retorno = "Cantidad Maxima: " + this._cantidadMaximaElementos.ToString() + "\r\n";
            for (int i = 0; i < this._colores.Count; i++)
            {
              retorno += this._colores[i] + "\r\n";
            }

            return retorno;


        }

        public PaletaColecciones SortMarca(int orden)
        {

            this._colores.Sort (PaletaColecciones.OrdenarPorMarca);
             if (orden == 0)
            {
                this._colores.Reverse();
            }
            return this;
        }

        public PaletaColecciones SortCantidad(int orden)
        {
            this._colores.Sort(PaletaColecciones.OrdenarPorCantidad);
            if (orden == 0)
            {
                this._colores.Reverse();
            }



            return this;
        }

        public PaletaColecciones SortColor(int orden)
        {
            this._colores.Sort(PaletaColecciones.OrdenarPorColor);
            if (orden == 0)
            {
                this._colores.Reverse();
            }
            return this;
        }

        #endregion

        #region Sobrecarga operadores

        public static implicit operator PaletaColecciones(int cant)
        {
            return new PaletaColecciones(cant);
        }

        public static explicit operator string(PaletaColecciones PaletaColecciones)
        {
            return PaletaColecciones._Mostrar();
        }

        public static bool operator ==(PaletaColecciones a, Tempera b)
        {
            bool retorno = false;

            for (int i = 0; i < a._colores.Count; i++)
            {
                if (a._colores.GetType() != null)
                {
                    if (a._colores[i] == b)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            // }
            return retorno;
        }


        public static bool operator !=(PaletaColecciones a, Tempera b)
        {
            return !(a == b);
        }

        public static PaletaColecciones operator +(PaletaColecciones palet, Tempera b)
        {
            int index = palet.ObtenerIndice(b);

            if (palet == b)
            {
                palet._colores[index] += b;
              
            }

            else
            {
                if (palet._cantidadMaximaElementos > palet._colores.Count)
                {
                        palet._colores.Add(b);                       
                }

            }

            return palet;

        }

                private int ObtenerIndice()
                {
                    int retorno = -1;
                    int cant = this._cantidadMaximaElementos;
                    for (int i = 0; i < cant; i++)
                    {
                        //if (this._colores.GetValue(i) == null)
                        //{
                            retorno = i;
                            break;
                      //  }
                    }
                    return retorno;
                }

                private int ObtenerIndice(Tempera tempera)
                {
                    int retorno = -1;
                    int cant = this._colores.Count;
                    for (int i = 0; i < cant; i++)
                    {
                        if (this._colores[i] == tempera)
                        {
                            retorno = i;
                            break;
                        }
                    }
                    return retorno;
                }
               
        public static PaletaColecciones operator -(PaletaColecciones a, Tempera b)
        {
            int indice = a.ObtenerIndice(b);
            if (a == b)
            {
                if (((int)a._colores[indice] - (int)b) < 1)
                {
                    a._colores.RemoveAt(indice);
                }

                else
                {
                    a._colores[indice] += (sbyte)((sbyte)b * -1);

                }

            }

            return a;
        }
        #endregion

        #region Ordenadores 

       
        public static int OrdenarPorCantidad(Tempera temp1, Tempera temp2)
        {
            int retorno = 0;

            if (temp1.Cantidad > temp2.Cantidad)
            {
                retorno = 1;

            }
            if (temp1.Cantidad < temp2.Cantidad)
            {
                retorno = -1;

            }

            return retorno;
        }

        public static int OrdenarPorMarca(Tempera temp1, Tempera temp2)
        {
            int retorno = 0;

            if (string.Compare(temp1.Marca, temp2.Marca, ignoreCase: true) > 0)
            {
                retorno = 1;

            }
            if (string.Compare(temp1.Marca, temp2.Marca, ignoreCase: true) < 0)
            {
                retorno = -1;

            }

            return retorno;
        }


        public static int OrdenarPorColor(Tempera temp1, Tempera temp2)
        {
            int retorno = 0;

            if (temp1.Color > temp2.Color)
            {
                retorno = 1;

            }
            if (temp1.Color < temp2.Color)
            {
                retorno = -1;

            }

            return retorno;
        }
        #endregion

        /*      public static List <Tempera> operator +(PaletaColecciones PaletaColeccioness, int indice)
               {
                   int i = indice >= PaletaColeccioness._colores.Count ? ++indice : --indice;// como funciona esto?

                   List<Tempera> aux = new List<Tempera>;

                   if ( aux.Count > PaletaColeccioness._cantidadMaximaElementos)
                   {
                       return PaletaColeccioness._colores;
                   }
                   else
                   {
                       return aux;

                   }


               }
               */
      //  #endregion

    }
}

//////[]{}