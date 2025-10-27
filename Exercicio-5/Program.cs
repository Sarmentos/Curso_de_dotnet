using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Numero do funcionário:");
        int numeroFuncionario = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Horas trabalhadas:");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor por hora:");
        double valorPorHora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salario =  horasTrabalhadas * valorPorHora;

        Console.WriteLine($"Número do funcionário: {numeroFuncionario}");
        Console.WriteLine($"Salário: U$ {salario .ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
