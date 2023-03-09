

class tarefa
{
    static void Main(string[] args)
    {

        int opçaoescolhida;


        while (true)
        {
            Menu();
            Console.Write("Escolha uma opção: ");
            opçaoescolhida = Convert.ToByte(Console.ReadLine());

            switch (opçaoescolhida)
            {
                case 0:
                    goto exit;
                case 1:
                    break;
                case 2:
                    Console.WriteLine("qual o seu nome? ");
                    string nome = Convert.ToString(Console.ReadLine());
                    Console.WriteLine((nome) + " qual a sua data de nascimento? ");
                    string[] datanascimento = Console.ReadLine().Split("/");
                    if (entradanafesta(datanascimento))
                    {
                        Console.WriteLine($"{nome} você pode entrar na festa. ");
                    }
                    else
                    {
                        Console.WriteLine($"{nome} você não pode entrar na festa. ");
                    }

                    break;
                case 3:
                    Console.WriteLine("Digite o tamanho da altura: ");
                    double alturat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o tamanho da base maior: ");
                    double baseMaior = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o tamanho da base menor: ");
                    double baseMenor = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine(areatrapezio(alturat, baseMaior, baseMenor));
                    break;
                case 4:
                    Console.WriteLine("Digite o valor do seu salário bruto: ");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(SalarioLiquido(salario));
                    break;
                case 5:
                    Console.WriteLine("Digite valor A");
                    double A = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite valor B");
                    double B = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite valor C");
                    double C = Convert.ToDouble(Console.ReadLine());
                    Bhaskara(A, B, C);


                    break;
                case 6:
                    Console.WriteLine("digite o raio do círculo: ");
                    double raio = Convert.ToDouble(Console.ReadLine());
                    double pi = Math.PI;
                    double area = pi * raio * raio;
                    Console.WriteLine(areacirculo(pi, raio, area));
                    break;
                case 7:
                    break;
                case 8:
                    Console.WriteLine("Digite seu peso: ");
                    double peso = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite sua altura: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(IndiceDeMassaCorporal(peso, altura));

                    break;
                case 9:
                    Console.WriteLine(" digite um numero ");
                    int numerodigitado = Convert.ToInt32(Console.ReadLine());
                    int soma = 0;
                    if (numerosperfeitos(numerodigitado, soma))
                    {
                        Console.WriteLine("seu número digitado é perfeito. ");
                    }
                    else
                    {
                        Console.WriteLine("seu número digitado não é perfeito. ");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 10:
                    break;
            }

        }
    exit:;
    }


    static void Menu()
    {
        Console.WriteLine("\n0- Sair do programa" +
            "\n1- Média de números ímpares" +
            "\n2- Informar se pode entrar na festa" +
            "\n3- Área do trapézio" +
            "\n4- Salário líquido" +
            "\n5- Bháskara" +
            "\n6- Área de um círculo" +
            "\n7- Volume da esfera" +
            "\n8- Índice de massa corporal - IMC" +
            "\n9- Números perfeitos" +
            "\n10- Valor dos ingressos\n");


    }

    static bool entradanafesta(string[] vari)
    {
        int ano = Convert.ToInt32(vari[2]);
        int meses = Convert.ToInt32(vari[1]);
        int dias = Convert.ToInt32(vari[0]);
        DateTime DA = DateTime.Now;
        int anoA = DA.Year;
        int mesesA = DA.Month;
        int diasA = DA.Day;
        int datanascimento = anoA - ano;
        if (datanascimento > 21)
        {
            return true;
        }
        if (datanascimento == 21)
        {
            if (meses < mesesA)
            {
                return true;
            }

            if (mesesA == meses)
            {
                if (dias <= diasA)
                {
                    return true;
                }
            }
        }

        return false;
    }

    static double areatrapezio(double alturat, double baseMaior, double baseMenor)
    {// opção 3
        double areat = 0.5 * alturat * (baseMaior + baseMenor) / 2;
        return areat;
    }

    static string SalarioLiquido(double salario)
    {//opção 4
        {
            double conta = 0;
            double previdencia = salario * 0.10;

            if (salario <= 1500.00)
            {
                Console.WriteLine("Isento");
            }

            else if (salario >= 1500.01 && salario <= 3000.00)
            {
                conta = ((salario - 2000.00) * 0.05) - previdencia;
                Console.WriteLine("seu salário teve um imposto incluído de 5%");
                return ($"{conta.ToString("0.00")}");
            }

            else if (salario >= 3000.01 && salario <= 8000.00)
            {
                conta = ((salario - 3000.01) * 0.19) - previdencia;
                Console.WriteLine("seu salário teve um imposto incluído de 19%");
                return ($"{conta.ToString("0.00")}");
            }

            else if (salario > 8000.00)
            {
                conta = ((salario - 8000.00) * 0.29) - previdencia;
                Console.WriteLine("seu salário teve um imposto incluído de 29%");
                return ($"{conta.ToString("0.00")}");
            }
            return ($"{(salario - previdencia).ToString("0.00")}");


        }
    }
    static double x1(double A, double B, double C, double raiz)
    {
        double x1 = ((-(B)) + raiz) / (2 * A);
        return x1;
    }
    static double x2(double A, double B, double C, double raiz)
    {
        double x2 = ((-(B)) - raiz) / (2 * A);
        return x2;
    }

    static double delta(double A, double B, double C)
    {
        return Math.Pow(B, 2) - 4 * (A * C);
    }
    static void Bhaskara(double A, double B, double C)
    {//opção 5
       

        if (delta(A,B,C) < 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }

        else
        {
             double raiz = Math.Sqrt(delta(A,B,C));

            Console.WriteLine("x1 = " + x1(A, B, C, raiz).ToString("0.00000"));
            Console.WriteLine("x2 = " + x2(A, B, C, raiz).ToString("0.00000"));


        }
    }

    static string areacirculo(double pi, double raio, double area)
    {// opção 6
        return area.ToString("Area do círculo = " + area.ToString("0.0000"));
    }

    static string IndiceDeMassaCorporal(double peso, double altura)
    {


        double resultadodaconta = peso / ((altura * altura));

        if (resultadodaconta <= 18.5)
        {
            return ("\n Voce está abaixo do peso.");
        }
        else if (resultadodaconta <= 24.9)
        {
            return ("\n Voce está em peso normal.");
        }
        else if (resultadodaconta <= 29.9)
        {
            return ("\n Voce está sobreopeso.");
        }
        else if (resultadodaconta <= 34.99)
        {
            return ("\n Voce está obesidade grau I.");
        }
        else if (resultadodaconta <= 39.99)
        {
            return ("\n Voce está obesidade grau II (Severa).");
        }
        else if (resultadodaconta >= 40.00)
        {
            return ("\n Voce está obesidade grau III (Mórbida).");
        }

        return ($"Resultado: {resultadodaconta}");


    }


    static bool numerosperfeitos(int numerodigitado, int soma)
    {//opção 9
        soma = 0;

        for (int i = 1; i <= numerodigitado / 2; i++)
        {
            if (numerodigitado % i == 0)
            {
                soma += i;
            }

        }
        if (soma == numerodigitado)
        {
            return true;
        }
        return false;
    }

}
