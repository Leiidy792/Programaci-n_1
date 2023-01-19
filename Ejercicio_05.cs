Console.WriteLine("Favor ingresar un Número de Tres Digitos: ");
int num = int.Parse(Console.ReadLine());
int dig1 = num / 100;
int dig2 = (num % 100) / 10;
int dig3 = (num % 100) % 10;
int may = dig1;
if (dig2 > may)
{
    may = dig2;
    Console.WriteLine("El Digito Mayor Esta en la posición 2");
}
else if (dig3 > may)
{
    may = dig3;
    Console.WriteLine("El Digito Mayor Esta en la posición 3");
}
else
    Console.WriteLine("El Digito Mayor Esta en la posición 1");