using System;
public class Progm
{
    static void Main(string[] args)
    {
        var a1 = double.TryParse(Console.ReadLine(), out var a);
        a1 = double.TryParse(Console.ReadLine(), out var b);

        Conta conta = new Conta();
        Console.WriteLine(conta.Soma(a, b));
        Console.WriteLine(conta.Subtrair(a, b));
        Console.WriteLine(conta.Multplicar(a, b));
        Console.WriteLine(conta.Dividir(a, b));
    }
}