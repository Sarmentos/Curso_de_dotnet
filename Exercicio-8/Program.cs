using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a numero:");
        int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (numero < 0)
        {
            Console.WriteLine("NEGATIVO");
        }
        else
        {
            Console.WriteLine("NAO NEGATIVO");
        }
    }
}
