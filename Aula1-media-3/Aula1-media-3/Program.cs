using Microsoft.Win32.SafeHandles;
using System;
class URI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite quantas notas:");
        var a = int.TryParse(Console.ReadLine(), out var num);
        double somanota = 0;
        for(int i = 0; i < num ; i++)
        {
            Console.WriteLine("Digite sua nota:");
            a = int.TryParse(Console.ReadLine(), out var nota);
            if (nota >= 0 && nota <= 10)
            {
                somanota += nota;
            }
            else
            {

                Console.WriteLine("Nota invalida.");
                i--;
            }
        }
        Console.WriteLine($"Média das notas é: {(somanota / num).ToString("F2")}");
    }
}