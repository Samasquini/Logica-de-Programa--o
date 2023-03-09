using System;
using System.Runtime.InteropServices;

class Intervalo
{
    static void Main(string[] args)
    {
        byte variavelDEopcao = 0;
        int inicio = 0;
        int termino = 0;
        double y = 0.0;
        string nome = "";
        double idade = 0.0;
        double DMaior = 0.0;
        double DMenor = 0.0;


        while (true)
        {
            MERU();

            Console.Write("\nEscolha uma Opcão: ");
            variavelDEopcao = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            switch (variavelDEopcao)
            {

                case 1:
                    Console.Write("\nDigite o inicío do intervalo: ");
                    inicio = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nDigite o TERMINO do intervaru ai: ");
                    termino = Convert.ToInt32(Console.ReadLine());

                    Intervaru(inicio, termino);

                    break;

                case 2:
                    Console.Write("\nDigite seu nome: ");
                    nome = Console.ReadLine();

                    Console.Write("\nDigite sua idade: ");
                    idade = Convert.ToDouble(Console.ReadLine());

                    PodeEntrar(nome, idade);
                    break;

                case 3:

                    Console.Write("\n Digite o tamanho da diagonal Maior: ");
                    DMaior = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\n Digite o tamanho da diagonal Menor: ");
                    DMenor = Convert.ToDouble(Console.ReadLine());

                    AreaLosango(DMaior, DMenor);
                    break;

                case 4:
                    Console.Write("\nDigite o Salário Bruto R$: ");
                    double Salarin = Convert.ToDouble(Console.ReadLine());

                    SalarioLiquido(Salarin);

                    break;

                case 5:


                    break;

                case 6:


                    Console.Write("\nDigite o raio do círculo: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    AreaCirculo(y);


                    break;

                case 7:

                    Console.Write("\nDigite o tamanho do raio da esfera:");
                    double raio = Convert.ToDouble(Console.ReadLine());

                    VolumeEsfera(raio);

                    break;

                case 8:

                    Console.Write("\n Digite sua Altura(M)²: ");
                    double altura = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\n Digite seu Peso(Kg): ");
                    double peso = Convert.ToDouble(Console.ReadLine());

                    IMC(altura, peso);


                    break;

                case 9:

                    Console.Write("\n Digite o número que desejas cosultar:");
                    int a = Convert.ToInt32(Console.ReadLine());


                    NumeroPerfect(a);

                    break;

                default:

                    Console.Write("\nOpção Inválida");
                    break;

                case 10:



                    break;

                case 11:

                    goto exit;
            }
        }
    exit:;
    }
    static void MERU()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("\n 1 - Média de números divisíveis por 5");
        Console.WriteLine(" 2 - Informar se pode entrar na festa");
        Console.WriteLine(" 3 - Área do Losango");
        Console.WriteLine(" 4 - Salário Líquido");
        Console.WriteLine(" 5 - Bhaskara");
        Console.WriteLine(" 6 - Área de um Círculo");
        Console.WriteLine(" 7 - Volume da Esfera");
        Console.WriteLine(" 8 - Índice de Massa Corporal - IMC");
        Console.WriteLine(" 9 - Números Perfeitos");
        Console.WriteLine(" 10 - Valor de Ingressos ");
        Console.WriteLine(" 11 - Sair do Programa");

        Console.ResetColor();
    }
    static void Intervaru(int inicio, int termino)
    {
        for (int i = inicio; i <= termino; i++)
        {
            Console.WriteLine(i);
        }
    }
    static bool PodeEntrar(string nome, double idade)
    {
        if (idade >= 16)
        {
            Console.WriteLine($"\n{nome}, você pode entrar na festa");
            return false;

        }
        else
        {
            Console.WriteLine($"\n{nome}, você não pode entrar na festa");
            return true;
        }

    }
    static double AreaLosango(double DMaior, double DMenor)
    {
        double diagonais = (DMaior * DMenor) / 2;
        Console.WriteLine($"\n Área do Losango = {diagonais}");
        return diagonais;
    }

    static void SalarioLiquido(double Salarin)
    {

    }
    static void Bhaskara(int inicio, int termino)
    {
        for (int i = termino; i >= inicio; i--)
        {

            if (i % 2 != 0)
            {
                Console.WriteLine(i);

            }
        }
    }
    static void AreaCirculo(double y)
    {
        double areaQuadrado = Math.PI * y * y;
        Console.WriteLine($"\nArea do Quadrado: {areaQuadrado.ToString("0.000")}");

    }
    static void VolumeEsfera(double raio)
    {

        double area = (4.0 / 3) * Math.PI * raio * raio * raio;
        Console.WriteLine($"Volume da Esfera: {area.ToString("0.000")}");

    }
    static double IMC(double altura, double peso)
    {
        double calculo = peso / Math.Pow(altura, 2);
        Console.WriteLine($"\n IMC = {calculo}");


        if (calculo < 18.5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Abaixo do Peso.");
            Console.ResetColor();
        }

        else if (calculo > 18.5 && calculo <= 24.9)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Peso Normal");
            Console.ResetColor();
        }
        else if (calculo > 25 && calculo <= 29.9)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Sobrepeso");
            Console.ResetColor();
        }
        else if (calculo > 30 && calculo <= 34.99)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Obesidade grau I");
            Console.ResetColor();

        }
        else if (calculo > 35 && calculo <= 39.99)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Obesidade grau II (Severa)");
            Console.ResetColor();
        }
        else if (calculo > 40)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n Obesidade grau III (Mórbida)");
            Console.ResetColor();
        }
        return peso / Math.Pow(altura, 2);

    }

    static void NumeroPerfect(int a)
    {
        for (int i = 0; i < a; i++)
        {
            int soma = 0;


            for (int j = 1; j < a; j++)
            {

                if (a % j == 0)
                {

                    soma += j;

                }

                if (soma == a)
                {
                    Console.WriteLine(a + " eh perfeito");
                }
                else
                {
                    Console.WriteLine($"{a} nao eh perfeito");

                }
            }
        }
    }

}