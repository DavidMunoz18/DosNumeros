using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosNumeros.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void metodo(double numeroDouble, int numeroInt) {



            for (int i = 1; i< numeroInt; i++)
            {
                numeroDouble = numeroDouble * numeroDouble;
               
            }

                 Console.WriteLine(numeroDouble);


        
        }   
    }
}
