using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bisiesto
{
    class Program2
    {
        
        public static bool bisiesto (int yearb)
        {
            if (yearb % 4 == 0 && (yearb % 100 != 0 || yearb % 400 == 0))
                return true;
            return false;

        }
        static void Main(string[] args)
        {
            //Bi Year
            int hola;
            Console.Write("Digite el Año ");
            hola = int.Parse(Console.ReadLine());
            if (bisiesto(hola) == true)
            {
                Console.WriteLine("El  año {0} es Bisiesto", hola);
            }
            else
            {
                Console.WriteLine("El  año {0} No Es Bisiesto", hola);
            }
            Console.ReadKey();
        }
    }
}