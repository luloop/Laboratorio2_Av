using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Tempera temp1 = new Tempera(10, ConsoleColor.Red, "LOlo");
            Tempera temp2= new Tempera(10, ConsoleColor.Red, "LOlo");
            if (temp1==temp2)
            {
                Console.WriteLine("Son iguales");
            }

        }
    }
}
