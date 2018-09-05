using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EjercicioClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Gonzalo";
            Sello.color = ConsoleColor.Blue;
            Console.WriteLine(Sello.Imprimir());
            Console.ReadLine();
            Sello.ImprimirEnColor();
            Console.ReadLine();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadLine();
        }
    }
}
