using System;
using System.Drawing;
using System.Dynamic;
using System.Runtime.Serialization;
using System.Windows.Markup;

class lista
{
    static void Main(string[] args)
    {
        DateTime DtAtual = DateTime.Now;
        while (true)
        {
            bool a;
            double raio;
            Console.Clear();
            Menu();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite um nùmero para ir para a opção: ");
            a = byte.TryParse(Console.ReadLine(), out var opc);
            Console.ResetColor();
            Console.Write("\n");

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
                        Console.WriteLine(Intervalo_Impar(inicio, fim).ToString("0.00"));
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.Write("Digite seu nome: ");
                        string nome = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"\n{nome}, você só podera entrar na festa se você tiver mais de 21 anos.\n");
                        Console.ResetColor();

                    data:;
                        Console.WriteLine("Digite a sua data de nascimento:");
                        a = DateTime.TryParse(Console.ReadLine(), out var aniver);

                        if (!a) { Erro(); goto data; }

                        Festa(aniver, nome);
                        Console.ReadKey();
                        break;

                    case 3:

                        Console.Write("Digite a altura do trapézio: ");
                        a = double.TryParse(Console.ReadLine(), out var Altura);
                        Console.Write("Digite a base menor do trapézio: ");
                        a = double.TryParse(Console.ReadLine(), out var Bmenor);
                        Console.Write("Digite a base maior do trapézio: ");
                        a = double.TryParse(Console.ReadLine(), out var Bmaior);
                        Console.Write($"A area do trapézio é {Trapezio(Altura, Bmenor, Bmaior)}");
                        Console.ReadKey();
                        break;

                    case 4:

                    salar:;
                        Console.Write("Digite o seu salário: ");
                        a = double.TryParse(Console.ReadLine(), out var salario);

                        if (Salario_Liquido(salario, 0) == -1) { Erro(); goto salar; }

                        Imposto(salario);
                        Console.ReadKey();
                        break;

                    case 5:

                    del:;

                        Console.WriteLine("Digite o valor de:");
                        Console.Write("A: ");
                        a = double.TryParse(Console.ReadLine(), out var A);
                        Console.Write("B: ");
                        a = double.TryParse(Console.ReadLine(), out var B);
                        Console.Write("C: ");
                        a = double.TryParse(Console.ReadLine(), out var C);

                        if (delta(A, B, C) == 0)
                        {
                            Console.WriteLine($"X = {Bhaskara(A, B, C, 3).ToString("F2")}");
                            goto fim;
                        }
                        if (Bhaskara(A, B, C, 1) == -0.001) { Erro(); goto del; }
                        else
                        {
                            Console.WriteLine($"O valor do X¹ é {Bhaskara(A, B, C, 1).ToString("F2")}");
                            Console.WriteLine($"O valor do X² é {Bhaskara(A, B, C, 2).ToString("F2")}");
                        }
                    fim:;
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Write("Digite o valor do raio: ");
                        a = double.TryParse(Console.ReadLine(), out raio);
                        Console.WriteLine($"O valor da area do círculo é {Area_do_Circulo(raio).ToString("0.00")}");
                        Console.ReadKey();
                        break;

                    case 7:

                        Console.Write("Digite o valor do raio: ");
                        a = double.TryParse(Console.ReadLine(), out raio);
                        Console.WriteLine($"O valor da area do círculo é {Volume_da_Esfera(raio).ToString("0.00")}");
                        Console.ReadKey();
                        break;

                    case 8:

                        Console.Write("Digite seu peso: ");
                        a = double.TryParse(Console.ReadLine(), out var peso);
                        Console.Write("Digite sua altura: ");
                        a = double.TryParse(Console.ReadLine(), out var altura);

                        Console.WriteLine($"Seu IMC é de {Imc(peso, altura).ToString("F3")}");

                        classificacaoIMC(peso, altura);
                        Console.ReadKey();
                        break;

                    case 9:

                        Console.Write("Digite um numero para verificar: ");
                        a = ulong.TryParse(Console.ReadLine(), out var numero);

                        Numero_Perfeito(numero);
                        Console.ReadKey();
                        break;

                    case 10:

                        Console.Write("Digite o numero de pessoas: ");
                        a = int.TryParse(Console.ReadLine(), out var NumPessoas);

                        Console.WriteLine($"O valor total dos ingressos é de {Ingressos(NumPessoas).ToString("C2")}.");
                        Console.ReadKey();
                        break;

                    default:

                        Console.Clear();
                        Erro();
                        Console.ReadKey();

                        break;
                }
            }
            else
            {
                Console.Clear();

                Erro();

                Console.ReadKey();
            }
        }
    saida:;
        Final();
    }

    //====================================================================[MENU]================================================================

    static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(
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
        Console.ResetColor();
    }

    //====================================================================[OPÇÃO 01]============================================================

    static double Intervalo_Impar(ulong inicio, ulong fim)
    {
        ulong soma = 0;
        ulong cont = 0;
        for (ulong i = inicio; i <= fim; i++)
        { if (i % 2 != 0) { soma += i; cont++; } }
        return soma / cont;
    }

    //====================================================================[OPÇÃO 02]============================================================

    static void Festa(DateTime aniver, string nome)
    {
        if (VerificarAniversario(aniver, 21))
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{nome}, você pode entrar na festa.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nome}, você NÃO pode entrar na festa.");
            Console.ResetColor();
        }
    }

    //====================================================================[OPÇÃO 03]============================================================

    static double Trapezio(double Altura, double Bmenor, double Bmaior)
    { return 0.5 * Altura * (Bmenor + Bmaior) / 2; }

    //====================================================================[OPÇÃO 04]============================================================

    static double Salario_Liquido(double x, int opc)
    {
        double Previdencia = x * 0.10;
        if (x >= 0 && x <= 1500)
        {
            double salario = x - Previdencia;
            if (opc == 0) return salario;
            if (opc == 1) return Previdencia;
        }
        if (x >= 1500.01 && x <= 3000)
        {
            double Imp = (x - 1500) * 0.05;
            double salario = (x - Imp) - Previdencia;
            if (opc == 0) return salario;
            if (opc == 1) return Previdencia;
            if (opc == 2) return Imp;
        }
        if (x >= 3000.01 && x <= 8000)
        {
            double Imp = ((x - 3000) * 0.19) + (1500 * 0.05);
            double salario = (x - Imp) - Previdencia;
            if (opc == 0) return salario;
            if (opc == 1) return Previdencia;
            if (opc == 2) return Imp;

        }
        if (x > 8000)
        {
            double Imp = ((x - 8000) * 0.29) + (1500 * 0.05) + (5000 * 0.19);
            double salario = (x - Imp) - Previdencia;
            if (opc == 0) return salario;
            if (opc == 1) return Previdencia;
            if (opc == 2) return Imp;
        }
        return -1;
    }
    static void Imposto(double salario)
    {
        if (salario >= 0 && salario <= 1500)
        {
            Console.WriteLine($"Seu salário líquido é de {Salario_Liquido(salario, 0).ToString("C2")}.\n" +
                $"Sendo isento de imposto.\n" +
                $"E com 10% de desconto da previdencia social de {Salario_Liquido(salario, 1).ToString("C2")}.");
        }
        if (salario >= 1500.01 && salario <= 3000)
        {
            Console.WriteLine($"Seu salário líquido é de {Salario_Liquido(salario, 0).ToString("C2")}.\n" +
                $"Com um de imposto de {Salario_Liquido(salario, 2).ToString("C2")}.\n" +
                $"E com 10% de desconto da previdencia social de {Salario_Liquido(salario, 1).ToString("C2")}.");
        }
        if (salario >= 3000.01 && salario <= 8000)
        {
            Console.WriteLine($"Seu salário líquido é de {Salario_Liquido(salario, 0).ToString("C2")}.\n" +
                $"Com um de imposto de {Salario_Liquido(salario, 2).ToString("C2")}.\n" +
                $"E com 10% de desconto da previdencia social de {Salario_Liquido(salario, 1).ToString("C2")}.");
        }
        if (salario > 8000)
        {
            Console.WriteLine($"Seu salário líquido é de {Salario_Liquido(salario, 0).ToString("C2")}.\n" +
                $"Com um de imposto de {Salario_Liquido(salario, 2).ToString("C2")}.\n" +
                $"E com 10% de desconto da previdencia social de {Salario_Liquido(salario, 1).ToString("C2")}.");
        }
    }

    //====================================================================[OPÇÃO 05]============================================================

    static double delta(double a, double b, double c)
    { return (Math.Pow(b, 2) + (-4 * (a * c))); }
    static double Bhaskara(double A, double B, double C, int opc)
    {
        if (A == 0) { Console.WriteLine("Impossivel dividir por 0."); return -0.001; }
        double raiz = Math.Sqrt(delta(A, B, C));
        if (delta(A, B, C) < 0) { Console.WriteLine("Delta < 0."); return -0.001; }

        if (delta(A, B, C) == 0)
        {
            if (opc == 3) return (-B + raiz) / (2 * A);
        }

        if (opc == 1) return (-B + raiz) / (2 * A);
        if (opc == 2) return (-B - raiz) / (2 * A);

        return -1;
    }

    //====================================================================[OPÇÃO 06]============================================================

    static double Area_do_Circulo(double raio)
    { return Math.PI * Math.Pow(raio, 2); }

    //====================================================================[OPÇÃO 07]============================================================

    static double Volume_da_Esfera(double raio)
    { return (4.0 / 3) * Math.PI * Math.Pow(raio, 3); }

    //====================================================================[OPÇÃO 08]============================================================

    static double Imc(double peso, double altura)
    { return peso / Math.Pow(altura, 2); }
    static void classificacaoIMC(double peso, double altura)
    {
        double IMC = Imc(peso, altura);

        Console.Write("\n");

        Console.ForegroundColor = ConsoleColor.Yellow;

        if (IMC < 18.5) Console.WriteLine("Ou seja, você está abaixo do peso.");

        else if (IMC >= 25 && IMC <= 29.9) Console.WriteLine("Ou seja, você está com sobre peso.");

        Console.ForegroundColor = ConsoleColor.Green;

        if (IMC >= 18.5 && IMC <= 24.9) Console.WriteLine("Ou seja, você está com o peso normal.");

        Console.ForegroundColor = ConsoleColor.Red;

        if (IMC >= 30 && IMC <= 34.9) Console.WriteLine("Atenção, você está com obesidade grau I.");

        else if (IMC >= 35 && IMC <= 39.9) Console.WriteLine("Atenção, você está com obesidade grau II.");

        else if (IMC >= 40) Console.WriteLine("Atençâo, você está com obesidade grau III.");

        Console.ResetColor();
    }

    //====================================================================[OPÇÃO 09]============================================================

    static bool Num_Per(ulong numero)
    {
        ulong soma = 0;
        for (ulong i = 1; i < numero; i++)
        {
            if (numero % i == 0) soma += i;
        }
        if (soma == numero) return true;
        else return false;
    }
    static void Numero_Perfeito(ulong numero)
    {
        if (Num_Per(numero)) Console.WriteLine($"{numero} é perfeito.");
        else Console.WriteLine($"{numero} não é perfeito.");
    }

    //====================================================================[OPÇÃO 10]============================================================

    static DateTime[] DTarray(int NumPessoas)
    {
        DateTime[] idades = new DateTime[NumPessoas];
        for (int i = 0; i < idades.Length; i++)
        {
            Console.Write($"Digite a data de nascimento da pessoa n° {i + 1}: ");
            var a = DateTime.TryParse(Console.ReadLine(), out idades[i]);
        }
        return idades;
    }
    static double Ingressos(int vs)
    {
        DateTime DtAtual = DateTime.Now;
        double soma = 0;
        DateTime[] Aniversario = DTarray(vs);
        for (int i = 0; i < Aniversario.Length; i++)
        {
            if (Ver_Aniver_Com_Intervalo(Aniversario[i], 0, 4)) soma += 0;
            if (Ver_Aniver_Com_Intervalo(Aniversario[i], 4, 59)) soma += 27;
            if (VerificarAniversario(Aniversario[i], 60)) soma += 13.50;
        }
        return soma;
    }
    static bool Ver_Aniver_Com_Intervalo(DateTime DtAniversario, int idade1, int idade2)
    {
        DateTime DtAtual = DateTime.Now;

        int[,] DATA = { { DtAniversario.Year, DtAniversario.Month, DtAniversario.Day },{ DtAtual.Year, DtAtual.Month, DtAtual.Day } };

        int anos = DATA[1, 0] - DATA[0, 0];
        if (anos > idade1 && anos < idade2) return true;
        if (anos == idade1 || anos == idade2)
        {
            if (DATA[0, 1] < DATA[1, 1]) return true;
            else if (DATA[0, 1] == DATA[1, 1])
            {
                if (DATA[0, 3] <= DATA[1, 3]) return true;
                else return false;
            }
            else return false;
        }
        return false;
    }

    //====================================================================[CORINGAS]============================================================

    static bool VerificarAniversario(DateTime DtAniversario, int idade)
    {
        DateTime DtAtual = DateTime.Now;
        int anos = DtAtual.Year - DtAniversario.Year;
        if (anos > idade) return true;
        if (anos == idade)
        {
            if (DtAniversario.Month < DtAtual.Month) return true;
            if (DtAniversario.Month == DtAtual.Month)
            {
                if (DtAniversario.Day <= DtAtual.Day) return true;
            }
        }
        return false;
    }
    static void Erro()
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("\nErro tente novamente.\n");

        Console.ResetColor();
    }
    //====================================================================[FINAL]===============================================================

    static void Final()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("O");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("b");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("r");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("i");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("g");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("a");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("d");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("o");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(" ");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("p");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("o");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("r");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(" ");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("u");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("s");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("a");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("r");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(",");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(" ");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("t");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("c");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("h");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("a");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("u");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(".");

        Console.ResetColor();
    }
}