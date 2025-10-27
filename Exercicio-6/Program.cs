using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o codigo de uma peça: ");
        int codigoPeca1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o numero de peças: ");
        int numeroPecas1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor unitário da peça: ");
        double valorUnitarioPeca1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o codigo da peça 2: ");
        int codigoPeca2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o numero de peças 2: ");
        int numeroPecas2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor unitário da peça 2: ");
        double valorUnitarioPeca2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double valorTotalPeca1 = numeroPecas1 * valorUnitarioPeca1;
        double valorTotalPeca2 = numeroPecas2 * valorUnitarioPeca2;
        double valorTotal = valorTotalPeca1 + valorTotalPeca2;
        
        Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
