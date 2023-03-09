using System;
class prova
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu();
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 0:
                    goto exite;
                case 1:
                    Console.WriteLine("digite um numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (primo(num) == true)
                    {
                        Console.WriteLine("o numero e primo");
                    }
                    else
                    {
                        Console.WriteLine("o numero nao e primo");
                    }
                    break;
                case 2:
                    Console.WriteLine("digite o raio da esfera");
                    int raio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("o raio e" + esfera(raio).ToString("0.0000"));
                    break;
                case 3:
                    Console.WriteLine("digite o numero de pessoas");
                    int pessoas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Preço total da viagem: R$" + pacotedeviagem(pessoas).ToString("0.00"));
                    break;
                default:
                    Console.WriteLine("opcao invalida");
                    break;
            }
        }
    exite:;
    }
    static void Menu()
    {
        Console.WriteLine("0 - sair");
        Console.WriteLine("1 - verificar se e primo");
        Console.WriteLine("2 - volume da esfera");
        Console.WriteLine("3 - Pacote de viagem");
    }
    static bool primo(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if(num % i == 0)
            {
                return false;


            }
        }
        return true;
    }
    static double esfera(int raio)
    {
        double esfer = (4.0/3.0) * Math.PI * (raio * raio * raio);
        return esfer;
    }
    static double idade(DateTime dataNascimento)
    {
        return (DateTime.Today - dataNascimento).Days / 365.2425;
    }
    static double pacotedeviagem(int pessoas)
    {
        double soma = 0;
        for (int i = 0; i < pessoas; i++)
        {
            Console.WriteLine("digite a idade da pessoa");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            if (idade(data) < 4)
            {
                soma = soma + 0;
            }
            if (idade(data) >= 4 && idade(data) < 8)
            {
                soma = soma + 30000;
            }
            if (idade(data) >= 8 && idade(data) < 60)
            {
                soma = soma + 40000;
            }
            if (idade(data) >= 60)
            {
                soma = soma + 32000;
            }
        }
        return soma;
    }

}