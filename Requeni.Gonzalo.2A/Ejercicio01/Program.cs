using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int numero;
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;
            bool flag = true;

            for(int i=0;i<5;i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                if(flag)
                {
                    maximo = numero;
                    minimo = numero;
                    flag = false;
                }
                else if(numero > maximo)
                {
                    maximo = numero;
                }
                else if(numero < minimo)
                {
                    minimo = numero;
                }
                promedio = promedio + numero;
            }
            promedio = promedio / 5;

            Console.WriteLine("\nMaximo: {0}", maximo);
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Promedio: {0:#,###.00}", promedio);
            Console.ReadLine();
        }
    }
}
