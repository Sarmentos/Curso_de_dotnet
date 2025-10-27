using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com o valor A:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entre com o valor B:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entre com o valor C:");
        double c = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Entre com o valor D:");
        double d = Convert.ToDouble(Console.ReadLine());

        double diferenca = (a * b) - (c * d);

        Console.WriteLine($"A diferença é: {diferenca}");
    }
}
