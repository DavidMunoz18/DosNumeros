using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosNumeros.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public double datoDouble()
        {

            Console.WriteLine("Ingresa un double");
            double numeroDouble = Convert.ToDouble(Console.ReadLine());
            return numeroDouble;

        }
        public int datoInt() 
        
        { 
            Console.WriteLine("Ingresa un int");
            int numeroInt = Convert.ToInt32(Console.ReadLine());
            return numeroInt; 
                }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("0. Se ejecuta caso 0");
            Console.WriteLine("1. Se ejecuta caso 1");
            opcionIntroducida= Console.ReadKey(true).KeyChar - '0';
            return opcionIntroducida;
        }
    }
}
