using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero:");
        int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (numero % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("IMPAR");
        }
    }
}
