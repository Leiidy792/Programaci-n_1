using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace  Ejercicio_3{
    class Program
    {static void Main(string[]args)
{
    int num, num2, resultado;
    Console.WriteLine("Digite el Primer Numero");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el Segundo Numero");
    num2 = Convert.ToInt32(Console.ReadLine());
    resultado = num + num2;
    if (num <= 99 && num >= 10)
    {
        if (num2 <= 99 && num2 >= 10)
        {
            if (resultado % 2 == 0)
            {
                Console.WriteLine(resultado + "Este Número es Par");
            }
            else
            {
                Console.WriteLine(resultado + "Este Número No es Par");
            }
        }
    }
        else
        {
            Console.WriteLine("Digite un Número de Dos Digitos");
            }

    else
    {
        Console.WriteLine("Digite un Número de Dos Digitos");
        }
        
        Console.ReadKey();
}

    }
}
