using System;
class recuperacao
{
    static void Main(string[] args)
    {
        while (true)
        {
            menu();
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    goto saida;
                case 1:
                    Console.WriteLine("digite um numero");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numero + " = " + fatorial(numero));
                    break;
                case 2:
                    Console.WriteLine("digite o numero de pessoas");
                    int pessoas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"o valor sera R$ {pacote(pessoas).ToString("0.00")}");
                    break;
                    default:
                    Console.WriteLine("opcao invalida");
                    break;
            }
        }
    saida:;
    }
    static void menu()
    {
        Console.WriteLine("0 - sair");
        Console.WriteLine("1 - Fatorial");
        Console.WriteLine("2 - Pacote de viagem");
    }
    static int fatorial(int numero)
    {
        int soma = 1;
        for (int i = numero; i >= 1; i--)
        {
            soma = soma * i;
        }
        return soma;
    }
    static byte CalculaIdade(DateTime dataNascimento)
    {
        return (byte)((DateTime.Today - dataNascimento).Days / 365.2425);
    }
    static double pacote(int pessoas)
    {
        double soma = 0;
        for (int i = 0; i < pessoas; i++)
        {
            Console.WriteLine($"digite a idade da pessoa {i + 1}");
            DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
            int idade = CalculaIdade(dataNascimento);
            if (idade < 3)
            {
                soma = soma + 0;
            }
            else if (idade >= 3 && idade < 8)
            {
                soma = soma + 28000;
            }
            else if (idade >= 8 && idade < 60)
            {
                soma = soma + 35000;
            }
            else if (idade >= 60)
            {
                soma = soma + 28000;
            }
        }
        return soma;
    }

}