using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com a hora inicial :");
        int horaInicial = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com a hora final :");
        int horaFinal = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int duracao;
        if (horaInicial < horaFinal)
        {
            duracao = horaFinal - horaInicial;
        }
        else
        {
            duracao = 24 - horaInicial + horaFinal;
        }
        Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    }
}
