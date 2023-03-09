using System;
class URI
{
    static void Main(string[] args)
    {
        double somanota = 0;
        Console.WriteLine("Digite o total da nota:");
        var a = int.TryParse(Console.ReadLine(), out var total);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite sua nota:");
            a = int.TryParse(Console.ReadLine(), out var nota);
            double total1 = (nota * 0.3);
            double total2 = (nota * 0.2);
            double total3 = (nota * 0.5);
            if (i == 0 && nota >= 0 && nota <= total)
            {
                somanota += total1;
            }
            else if (i == 1 && nota >= 0 && nota <= total)
            {
                somanota += total2;
            }
            else if (i == 2 && nota >= 0 && nota <= total)
            {
                somanota += total3;
            }
            else
            {
                Console.WriteLine("Nota invalida.");
                i--;
            }
        }
        Console.WriteLine($"Média das notas é: {(somanota).ToString("F2")}");
    }
}