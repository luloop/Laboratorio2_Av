using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Cosa
    {
        public string cadena;
        public double numero;
        public DateTime fecha;

        public static string Mostrar(Cosa dato)
        {
            return dato.Mostrar();
        }

        private string Mostrar()
        {
            return this.cadena + this.numero.ToString() + this.fecha.ToString();
        }

        public Cosa()
        {
            this.cadena = "Sin valor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }

        public Cosa(string f) :this()
        {
            this.cadena = f;
        }

        public Cosa(string a, DateTime b) :this(a)
        {
            this.fecha = b;
        }

        public void EstablecerValor(string nombre)
        {
            this.cadena = nombre;
        }

        public void EstablecerValor(double num)
        {
            this.numero = num;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }
    }
}
