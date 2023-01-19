using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite un número de 5 dígitos: ");
        int num = int.Parse(Console.ReadLine());
        int numInver = int.Parse(new string(num.ToString().Reverse().ToArray()));
        if (num == numInver)
        {
            Console.WriteLine("El número es Capicúa");
        }
        else
        {
            Console.WriteLine("El número no es Capicúa");
        }
    }
}