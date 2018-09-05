using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta obj1 = new Tinta();
            Tinta obj2 = new Tinta(ConsoleColor.Red);
            Console.WriteLine(Tinta.Mostrar(obj1));
            if(obj1 == obj2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            Pluma obj3 = new Pluma(10,"asd",obj2);
            Pluma obj4 = new Pluma(10, "ggfg", obj1);
            Pluma obj5 = new Pluma();

            Console.WriteLine(obj3);
            Console.WriteLine(obj4);
            obj3 += obj2;
            obj4 -= obj1;
           // obj3 -= obj1;
            Console.WriteLine(obj3);
            Console.WriteLine(obj4);
            Console.WriteLine(obj5);
            Console.ReadLine();
        }
    }
}
