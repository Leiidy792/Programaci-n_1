using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace  Ejercicio_3{
    class Program
    {static void Main(string[]args)
    {
        int num, digito, suma;
        Console.WriteLine("digite un numero entero: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 100)
        {
            Console.Write("El número tiene más de dos digitos");
           
        }
        else if (num < 100)
            num = num * (-1);
        {
            digito = num - (num / 10) * 10;
            suma = digito;
            do
            {
                num = (num - digito) /10;
                digito = num - (num / 10) * 10;
                suma = suma + digito;

            }
            while (num > 0);
            Console.Write("La suma de los digitos del numero es igual; "+suma);
            Console.ReadLine();
            
        }
                }
        }

    }
