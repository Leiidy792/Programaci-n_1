int num;
Console.WriteLine("Ingrese un número entero de tres dígitos: ");
num = int.Parse(Console.ReadLine());

int dig1 = num / 100;
int dig2 = (num / 10) % 10;
int dig3 = num % 10;

if (dig1 % dig2 == 0 || dig1 % dig3 == 0)
{
    Console.WriteLine("El primer dígito es múltiplo de algún otro dígito");
}
else if (dig2 % dig1 == 0 || dig2 % dig3 == 0)
{
    Console.WriteLine("El segundo dígito es múltiplo de algún otro dígito");
}
else if (dig3 % dig1 == 0 || dig3 % dig2 == 0)
{
    Console.WriteLine("El tercer dígito es múltiplo de algún otro dígito");
}
else
{
    Console.WriteLine("No hay Digitos Multiplos Entre Ellos");
}