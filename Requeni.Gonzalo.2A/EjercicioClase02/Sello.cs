using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            string cadena;
            string retorno;
            if(Sello.TryParse(Sello.mensaje,out cadena))
            {
                Sello.mensaje = cadena;
                retorno = Sello.ArnarFormatoMensaje(Sello.mensaje);
            }
            else
            {
                retorno = Sello.mensaje;
            }
            return retorno;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.BackgroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private static string ArnarFormatoMensaje(string mensaje)
        {
            string retorno = "";
            int cantCaracteres = mensaje.Length + 2;

            for(int i=0;i<cantCaracteres;i++)
            {
                retorno = retorno + "*";
            }

            retorno = retorno + "\n" + "*" + mensaje + "*" + "\n" + retorno;

            return retorno;
        }

        private static bool TryParse(string mensaje, out string cadena)
        {
            bool retorno = true;
            cadena = mensaje;
            if(mensaje.Length == 0)
            {
                retorno = false;
            }
            
            return retorno;
        }
    }
}
