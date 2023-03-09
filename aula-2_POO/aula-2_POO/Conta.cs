public class Conta
{
    public string[] nome;
    public string tipo;
    public double saldoTotal;

    public void Sacar(double saque)
    {
        if(saldoTotal < saque)
        {
            Console.Clear();
            Console.WriteLine("Saldo insuficiente.");
            Console.WriteLine($"Saldo atual {saldoTotal.ToString("C2")}.");
        }
        else if(saque < 0)
        {
            Console.WriteLine("Saque inválido.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Saque efetuado com sucesso.");
            saldoTotal -= saque;
            Console.WriteLine($"Saldo atual {saldoTotal.ToString("C2")}.");
        }
    }

    public void ConsultaConta()
    {
        while(true)
        {
        inicio:;
            Console.Clear();
            Console.WriteLine($"sr.(sra.) {nome[0]}, deseja consultar sua conta?" +
                "\n1 - Sim." +
                "\n0 - Não.");
            var a = int.TryParse(Console.ReadLine(), out var opc);
            if (a)
            {
                if (opc == 0) break;
                else if (opc == 1)
                {
                es:;
                    Console.Clear();
                    Console.WriteLine("Você deseja..." +
                        "\n0 - Sair." +
                        "\n1 - Consultar o saldo total." +
                        "\n2 - Fazer um saque." +
                        "\n3 - Zerar minha conta.");
                    a = int.TryParse(Console.ReadLine(), out opc);
                    if (a)
                    {
                        if (opc == 3)
                        {
                            saldoTotal = 0;
                            Console.WriteLine($"Saldo atual {saldoTotal.ToString("C2")}.");
                        }
                        else if (opc == 2)
                        {
                            Console.WriteLine($"Saldo atual {saldoTotal.ToString("C2")}.");
                            Console.Write("Qual sera o valor do saque? Formato: 99.999,99" +
                                "\nR$ ");
                            a = double.TryParse(Console.ReadLine(), out var valor);
                            Sacar(valor);
                        }
                        else if (opc == 1)
                        {
                            Console.WriteLine($"Saldo atual {saldoTotal.ToString("C2")}.");
                        }
                        else if (opc == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Código inválido.");
                            Console.ReadKey();
                            goto es;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Código inválido.");
                        Console.ReadKey();
                        goto es;
                    }
                }
                else
                {
                    Console.WriteLine("Código inválido.");
                    Console.ReadKey();
                    goto inicio;
                }
            }
            else
            {
                Console.WriteLine("Código inválido.");
                Console.ReadKey();
                goto inicio;
            }
            Console.ReadKey();
        }
    }
    public int MaiorSaldo(double valor1, double valor2, double valor3)
    {
        if(valor1 > valor2 && valor1 > valor3)
        {
            return 1;
        }
        else if(valor2 > valor1 && valor2 > valor3)
        {
            return 2;
        }
        else
        {
            return 3;
        }
    }
}
