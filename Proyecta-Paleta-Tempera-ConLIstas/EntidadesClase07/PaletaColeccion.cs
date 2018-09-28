using System;
using System.Collections.Generic;
using System.Text;



namespace EntidadesClase07
{
    public class PaletaColecciones
    {
        #region Atributos
        private List <Tempera> _colores;
        private int _cantidadMaximaElementos;

        #endregion

        #region Constructor

        private PaletaColecciones() : this(5)
        {

        }

        private PaletaColecciones(int cantidad)
        {
            this._cantidadMaximaElementos = cantidad;
            this._colores= new List <Tempera>();
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
                if (this._colores.GetType()== null)
                {
                    retorno += this._colores[i] + "\r\n";
                }
            }

            return retorno;


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
     
            for (int i = 0; i < a._cantidadMaximaElementos; i++)
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

        public static PaletaColecciones operator +(PaletaColecciones a, Tempera b)
        {
            int index = a._colores.IndexOf(b);

            if (a._cantidadMaximaElementos < a._colores.Count)
            {

                if (a == b)
                 {
                a._colores[index] += b;
                return a;
                }
                 else
                {
                     if (index!= -1)
                      {
                        a._colores.Add(b);
                        return a;
                        }

                
            }
            }
            return a;


        }

        /*
                private int ObtenerIndice()
                {
                    int retorno = -1;
                    int cant = this._cantidadMaximaElementos;
                    for (int i = 0; i < cant; i++)
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
                        if (this._colores[i] == tempera)
                        {
                            retorno = i;
                            break;
                        }
                    }
                    return retorno;
                }
                */

        public static PaletaColecciones operator -(PaletaColecciones a, Tempera b)
        {
            int indice = a._colores.IndexOf(b);
            if (a == b)
            {
                if (((sbyte)a._colores[indice] - (sbyte)b) < 1)
                {
                    a._colores.Remove(b);
                }

                else
                {
                    a._colores[indice] += (sbyte)((sbyte)b * -1);

                }

            }

            return a;
        }

        public static Tempera[] operator +(PaletaColecciones PaletaColecciones, int indice)
        {
            int i = indice >= PaletaColecciones._colores.Count ? ++indice : --indice;// como funciona esto?

            Tempera[] aux = new Tempera[i];

            PaletaColecciones._colores.CopyTo(aux, 0);

            return aux;

        }

        #endregion

    }
}

//////[]{}