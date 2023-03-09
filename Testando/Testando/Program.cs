using System;
class lista
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu();
            var a = int.TryParse(Console.ReadLine(), out var opc);
            if (a)
            {
                switch (opc)
                {
                    case 0:
                        goto saida;
                    case 1:
                        Console.WriteLine("Digite o numero do inicio do intervalo:");
                        a = ulong.TryParse(Console.ReadLine(), out var inicio);
                        Console.WriteLine("Digite o numero do fim do intervalo:");
                        a = ulong.TryParse(Console.ReadLine(), out var fim);
                        Console.WriteLine(Opc1(inicio, fim));
                        break;
                        Console.Clear();
                    case 2:
                        Console.Write("Digite seu nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite a sua data de nascimento no formato dd/mm/aaaa: ");
                        string[] x = Console.ReadLine().Split("/");
                        if (Opc2(x))
                        {
                            Console.WriteLine($"{nome}, você pode entrar na festa.");
                        }
                        else
                        {
                            Console.WriteLine($"{nome}, você NÃO pode entrar na festa.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção ínvalida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tente novante.");
            }
        }
    saida:;
    }
    static void Menu()
    {
        Console.WriteLine(
            "Digite um nùmero para ir para a opção:\n" +
            "0 - Sair;\n" +
            "1 - Média de números ímpares;\n" +
            "2 - Informar se pode entrar na festa;\n" +
            "3 - Área do trapézio;\n" +
            "4 - Salário líquido;\n" +
            "5 - Bhaskara;\n" +
            "6 - Área de um círculo;\n" +
            "7 - Volume da esfera;\n" +
            "8 - Índice de Massa Corporal - IMC;\n" +
            "9 - Números perfeitos;\n" +
            "10 - Valor de ingressos;\n"
            );
    }
    static double Opc1(ulong x, ulong y)
    {
        ulong soma = 0;
        ulong cont = 0;
        for (ulong i = x; i <= y; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
                cont++;
            }
        }
        return soma / cont;
    }
    static bool Opc2(string[] x)
    {
        int z = Convert.ToInt32(x[2]);
        int y = 2022 - z;
        if (y >= 21)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}