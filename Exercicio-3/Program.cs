using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ebtre com o valor do raio do círculo:");
        double raio = Convert.ToDouble(Console.ReadLine());
        
        double area = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine($"A área do círculo é: {area}");
    }
}
