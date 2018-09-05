using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa datos = new Cosa();
            datos.cadena = "Gonzalo";
            datos.numero = 1234;
            datos.fecha = DateTime.Now;

            Console.WriteLine(Cosa.Mostrar(datos));
            Console.ReadLine();
        }
    }
}
