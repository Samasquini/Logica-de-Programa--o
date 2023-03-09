using System;

class logica
{
    static void Main(string[] args)
    {
        byte opcaoEscolhida = 0;
        ulong inicio = 0;
        ulong fim = 0;
        string nome = "";
        double Base = 0.0;
        double Altura = 0.0;
        double y = 0.0;

        byte gtdPessoas = 0;
        DateTime dataNascimento;
        DateTime Hoje = DateTime.Now;

        while (true)
        {
            MENU();

            Console.Write("\nEscolha uma Opcão: ");
            opcaoEscolhida = Convert.ToByte(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 0: //Sair do programa
                    goto saida;

                case 1: //Média de números pares
                    Console.Write("\nDigite o inicío do intervalo: ");
                    inicio = Convert.ToUInt64(Console.ReadLine());

                    Console.Write("\nDigite o fim do intervalo : ");
                    fim = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine($"\n Media = {Media(inicio, fim)}\n");

                    break;

                case 2: //Informar se pode entrar na festa
                    Console.Write("\nDigite seu nome: ");
                    nome = Console.ReadLine();

                    Console.Write("\nDigite sua idade: ");
                    dataNascimento = Convert.ToDateTime(Console.ReadLine());


                    PodeEntrar(nome, dataNascimento, Hoje);
                    break;



                case 3: //Área do triângulo retângulo

                    Console.Write("\n Digite o tamanho da Base: ");
                    Base = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\n Digite o tamanho da Altura: ");
                    Altura = Convert.ToDouble(Console.ReadLine());

                    AraTrianguloRetangulo(Base, Altura);
                    break;

                case 4: //Salário líquido
                    Console.Write("\nDigite seu Salário: ");
                    double Salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Salario Liquido = " + SalarioLiquido(Salario));

                    SalarioLiquido(Salario);

                    break;

                case 5: //Bhaskara

                    Console.Write("\n Digite o valor de A: ");
                    double a = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Digite o valor de B: ");
                    double b = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Digite o valor de C: ");
                    double c = Convert.ToInt32(Console.ReadLine());

                    if (a == 0)
                    {
                        Console.WriteLine("Impossivel de dividir por 0");
                    }

                    delta(a, b, c);
                    Bhaskara(a, b, c);

                    break;

                case 6: //Área de um círculo

                    Console.Write("\nDigite o raio do Círculo: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    AreasCirculo(y);

                    break;

                case 7: //Volume da esfera

                    Console.Write("\nDigite o tamanho do raio da esfera:");
                    double raio = Convert.ToDouble(Console.ReadLine());

                    VolumeEsfera(raio);
                    break;

                case 8: // Índice de Massa Corporal - IMC

                    Console.Write("\n Digite sua Altura(M)²: ");
                    double altura = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\n Digite seu Peso(Kg): ");
                    double peso = Convert.ToDouble(Console.ReadLine());

                    IndiceMassaCoporal(altura, peso);

                    break;

                case 9: // Números perfeitos

                    Console.Write("\n Digite um número: ");
                    a = Convert.ToInt32(Console.ReadLine());




                    break;

                default:

                    Console.Write("\nOpção Inválida");
                    break;

                case 10: //Valor de ingressos

                    Console.Write("Quantos ingressos você quer? ");
                    gtdPessoas = Convert.ToByte(Console.ReadLine());
                    DateTime[] idades = new DateTime[gtdPessoas];
                    double preco = 0.0;


                    for (int i = 0; i < idades.Length; i++)
                    {
                        Console.Write($"Digite a idade da pessoa {i + 1} ");
                        idades[i] = Convert.ToDateTime(Console.ReadLine());
                        preco +=    CalculaIngresso(idades[i]);

                    }

                    Console.WriteLine(preco.ToString("C2"));

                    break;


            }
        }
    saida:;
    }
    static void MENU()
    {
        Console.WriteLine("Escolha uma opção: ");

        Console.WriteLine("\n 0 - Sair do Programa ");
        Console.WriteLine(" 1 - Média de números pares ");
        Console.WriteLine(" 2 - Informar se pode entrar na festa ");
        Console.WriteLine(" 3 - Área do triângulo retângulo ");
        Console.WriteLine(" 4 - Salário Líquido");
        Console.WriteLine(" 5 - Bhaskara ");
        Console.WriteLine(" 6 - Área de um Círculo ");
        Console.WriteLine(" 7 - Volume da esfera ");
        Console.WriteLine(" 8 - Índice de Massa Corporal - IMC ");
        Console.WriteLine(" 9 - Números Perfeitos ");
        Console.WriteLine(" 10 - Valor de Ingressos ");


    }
    static double Media(ulong inicio, ulong fim)
    {
        ulong soma = 0;
        ulong contadorPar = 0;

        for (ulong i = inicio; i <= fim; i++)
        {
            if (i % 2 == 0)
            {
                soma += i;
                contadorPar++;
            }

        }
        return soma / contadorPar;

    }

    static bool PodeEntrar(string nome, DateTime dataNascimento, DateTime Hoje)
    {
        int subtracaoDEanos = Hoje.Year - dataNascimento.Year;

        if (subtracaoDEanos >= 18)
        {

            Console.WriteLine($"\n{nome}, você pode entrar na festa");
            return true;

        }
        else
        {
            Console.WriteLine($"\n{nome}, você não pode entrar na festa");
            return false;
        }
    }

    static double AraTrianguloRetangulo(double Base, double Altura)
    {
        double diagonais = (Base * Altura) / 2;
        Console.WriteLine($"\n Área do Triangulo e retangulo = {diagonais}");
        return diagonais;
    }

    static double SalarioLiquido(double SalarioBruto)
    {
        double SalarioLiquido = 0;


        if (SalarioBruto <= 2500)
        {
            SalarioLiquido = SalarioBruto * 0.12;
        }
        else if (SalarioBruto >= 2500.01 && SalarioBruto == 5000)
        {
            SalarioLiquido = ((SalarioBruto - 2500) * 0.09);
        }
        else if (SalarioBruto >= 5000.01 && SalarioBruto == 9000)
        {
            SalarioLiquido = ((SalarioBruto - 5000) * 0.20) + (2500 * 0.09);
        }
        else if (SalarioBruto > 9000)
        {
            SalarioLiquido = ((SalarioBruto - 2500) * 0.30) + (2500 * 0.09) + (4000 * 0.20);
        }
        return (SalarioBruto - SalarioLiquido) - (SalarioBruto * 0.12);
    }

    static double x1(double A, double B, double C, double raiz)
    {
        double x1 = ((-B) + raiz / (2 * A));
        return x1;
    }
    static double x2(double A, double B, double C, double raiz)
    {
        double x2 = ((-B) - raiz) / (2 * A);
        return x2;
    }
    static double delta(double B, double C, double A)
    {
        return Math.Pow(B, 2) - 4 * (A * C);
    }
    static void Bhaskara(double A, double B, double C)
    {
        if (delta(A, B, C) < 0 || A == 0)
        {
            Console.WriteLine(" \n Impossível de Calcular ");
        }
        else
        {
            double raiz = Math.Sqrt(delta(A, B, C));

            Console.WriteLine("\n x1 = " + x1(A, B, C, raiz).ToString("0.00000"));
            Console.WriteLine(" x2 = " + x2(A, B, C, raiz).ToString("0.00000"));
        }
    }
    static void AreasCirculo(double y)
    {
        double areaCirculo = Math.PI * y * y;
        Console.WriteLine($"\nArea do Circulo: {areaCirculo.ToString("0.000")}");

    }
    static void VolumeEsfera(double raio)
    {

        double area = (4.0 / 3) * Math.PI * raio * raio * raio;
        Console.WriteLine($" Volume da Esfera: {area.ToString("0.000")}");

    }
    static double IndiceMassaCoporal(double altura, double peso)
    {
        double calcular = peso / Math.Pow(altura, 2);
        Console.WriteLine($"\n IMC = {calcular.ToString("F3")}");


        if (calcular <= 18.5)
        {
            Console.WriteLine("\n Abaixo do Peso.");
        }
        else if (calcular > 18.5 && calcular <= 24.9)
        {
            Console.WriteLine("\n Peso Normal");
        }
        else if (calcular > 25 && calcular <= 29.9)
        {
            Console.WriteLine("\n Sobrepeso");
        }
        else if (calcular > 30 && calcular <= 34.99)
        {
            Console.WriteLine("\n Obesidade grau I");
        }
        else if (calcular > 35 && calcular <= 39.99)
        {
            Console.WriteLine("\n Obesidade grau II (Severa)");
        }
        else if (calcular >= 40)
        {
            Console.WriteLine("\n Obesidade grau III (Mórbida)");
        }
        return peso / Math.Pow(altura, 2);
    }

    static void NumeroPerfeito(int a)
    {
        int soma = 0;

        for (int i = 0; i < a; i++)
        {
            for (int t = 1; t < a; t++)
            {

                if (a % t == 0)
                {
                    soma += t;
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
    static double CalculaIngresso(DateTime idade2)
    {
        DateTime hoje = DateTime.Now;
        int idade = hoje.Year - idade2.Year;

        if (idade < 5)
        {
            return 0;
        }

        else if (idade >= 5 && idade <= 59)
        {
            return 30;
        }
        else if (idade >= 60)
        {
            return 15;
        }


        return 0;
    }
}