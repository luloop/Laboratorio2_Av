using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            int numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while(numero <= 0)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numero = int.Parse(Console.ReadLine());
            }
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El numero ingresado es {0}, su cuadrado es {1} y su cubo es {2}", numero, cuadrado, cubo);
            Console.ReadLine();
        }
    }
}
