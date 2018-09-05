using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            int numero;
            int primo=0;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numero = int.Parse(Console.ReadLine());
            }

            for(int i=1;i<=numero;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i%j == 0)
                    {
                        primo++;
                    }
                }
                if(primo == 2)
                {
                    Console.WriteLine(i);
                }
                primo = 0;
            }
            Console.ReadLine();
        }
    }
}
