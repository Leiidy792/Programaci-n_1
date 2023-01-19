using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2{
    class Program
    {static void Main(string[]args)
    {
        Console.Write("Digita un Numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int i = num - 1;
        while (i >= 2)
        {
            bool division = (num % i == 0);
            if (division)
            {
        Console.WriteLine("El numero no es primo");
            }
            i = i - 1;
        }
        Console.WriteLine ("El numero es Primo");

                    if (num <= 0)
                    {
            Console.WriteLine("El numero es negativo");
        }
                        else if (num > 0)
        {
            Console.WriteLine("El numero es positivo");
        }
            Console.ReadKey();
                }
    }
    }
