using System;
using System.Runtime.ConstrainedExecution;

class Prova
{
    static void Main(string[] args)
    {
        while (true)
        {
            menu();
            Console.Write("\nEscolha a opção desejada: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Informe a área em metros quadrados: ");
                    int metros = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(calc(metros) + " Lata(s) de tinta.");
                    double latas = calc(metros);
                    Console.WriteLine("Total = " + preco(latas).ToString("C2"));
                    break;

                case 2:
                tentativa:;
                    Console.Write("\nQuantas pessoas querm o pacote: ");
                    byte pessoas = Convert.ToByte(Console.ReadLine());

                    if (pessoas <= 0)
                    {
                        Console.WriteLine("tente novamente");
                        goto tentativa;
                    }


                    if (pessoas == 1)
                    {
                        string individual = "individual";
                        calculaQuarto(pessoas, individual);
                        byte[] pessoas1 = new byte[pessoas];
                        for (int i = 0; i < pessoas1.Length; i++)
                        {
                            Console.WriteLine($"Digite a data de nascimento da pessoa {i = 1}");
                            pessoas1[i] = calculaIdade(Convert.ToDateTime(Console.ReadLine()));
                        }
                        double calc2 = calc1(pessoas1);
                        Console.WriteLine(calc2.ToString("C2"));
                    }
                    else if(pessoas == 2)
                    {
                        Console.Write("Quartos individuais ou duplos: ");
                        string quartos1 = Console.ReadLine().ToLower();
                        double calc = calculaQuarto(pessoas, quartos1);

                        byte[] pessoas1 = new byte[pessoas];
                        for (int i = 0; i < pessoas1.Length; i++)
                        {
                            Console.WriteLine($"Digite a data de nascimento da pessoa {i + 1}");
                            pessoas1[i] = calculaIdade(Convert.ToDateTime(Console.ReadLine()));
                        }

                        double calc2 = calc1(pessoas1);
                        Console.WriteLine((calc + calc2).ToString("C2"));
                    }
                    else if(pessoas >= 3)
                    {
                        Console.Write("Quartos individuais, duplos ou triplos: ");
                        string quartos = Console.ReadLine().ToLower();
                        double calc = calculaQuarto(pessoas, quartos);
                        byte[] pessoas1 = new byte[pessoas];

                        for (int i = 0; i < pessoas1.Length; i++)
                        {
                            Console.WriteLine($"Digite a data de nascimento da pessoa {i = 1}");
                            pessoas1[i] = calculaIdade(Convert.ToDateTime(Console.ReadLine()));
                        }

                        double calc2 = calc1(pessoas1);
                        Console.WriteLine((calc + calc2).ToString("C2"));
                    }

                    



                    break;

                case 3:
                    goto final;
            }
        }
    final:;
    }
    static void menu()
    {
        Console.WriteLine("\n1 - Calculo Latas Tinta.\n2 - Pacote de viagens.\n3 - Sair.");
    }

    static byte calculaIdade(DateTime dataNascimento)
    {
        return (byte)((DateTime.Today - dataNascimento).Days / 365.2425);
    }

    static double calculaQuarto(int quantidadePessoas, string quartos)
    {
        if (quartos.Contains("individual"))
        {
            double conta = (34220 * 0.16) + 34220;
            return conta;
        }
        else if (quartos.Contains("duplos"))
        {
            return 34220 * quantidadePessoas; 

        }
        else if (quartos.Contains("triplo"))
        {
            double conta = 34220 - (34220 * 0.07);
            return conta * quantidadePessoas;
        }
        return 0;
    }
    static double calc1(byte[] idade)
    {
        double soma = 0;
        for (int i = 0; i < idade.Length; i++)
        {
            if (idade[i] < 3)
            {
                soma += 0;
            }
            else if (idade[i] >= 65)
            {
                soma += (34220 * 0.18);
            }
        }
        return soma;
    }
    static double calc(int metros)
    {
        double calc = metros / 3;
        double calc2 = calc / 18;
        int latasTinta = Convert.ToInt32(Math.Ceiling(calc2));
        return latasTinta;
    }
    static double preco(double latas)
    {
        return latas * 80;
    }


}

