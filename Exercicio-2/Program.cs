
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        int soma = valor1 + valor2;
        
        Console.WriteLine($"SOMA = {soma}");
    }
}