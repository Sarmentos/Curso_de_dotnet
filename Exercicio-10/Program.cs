using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o Valor A:");
        int valorA = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o Valor B:");
        int valorB = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int multiplos = 0;
        for (int i = 1; i <= valorB; i++)
        {
            if (i % valorA == 0)
            {
                multiplos++;
            }
        }
        
        if (multiplos > 0)
        {
            Console.WriteLine($"Existem {multiplos} múltiplos de {valorA} entre 1 e {valorB}.");
        }
        else
        {
            Console.WriteLine($"Não existem múltiplos de {valorA} entre 1 e {valorB}.");
        }
    }
}
