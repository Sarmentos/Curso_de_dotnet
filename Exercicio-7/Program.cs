using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com o valor A:");
        double a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com o valor B:");
        double b = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com o valor C:");
        double c = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaTriangulo = (a * c) / 2.0;
        double areaCirculo = Math.PI * Math.Pow(c, 2);
        double areaTrapezio = ((a + b) * c) / 2.0;
        double areaQuadrado = Math.Pow(b, 2);
        double areaRetangulo = a * b;

        Console.WriteLine($"Área do triângulo: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Área do círculo: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Área do trapézio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Área do quadrado: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Área do retângulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}
