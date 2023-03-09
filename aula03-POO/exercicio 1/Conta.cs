public class Conta
{
    public string nomeCliente;
    public string Tipo;
    public double saldoTotal;

    public Conta()
    {

    }
    public Conta(string nome,double saldo)
    {
        this.saldoTotal = saldo;
        this.nomeCliente = nome;
    }
    public void Sacar(double valor)
    {
        if(valor <= saldoTotal)
        {
            saldoTotal -= valor;
            Console.WriteLine($"Saque efetuado, saldo restante: {saldoTotal.ToString("C2")}");
        }
        else Console.WriteLine($"Valor invalido, saldo atual: {saldoTotal.ToString("C2")}");
    }
    public void Deposito(double valor)
    {
        if(valor > 0)
        {
            saldoTotal += valor;
            Console.WriteLine($"Deposito efetuado, saldo atual: {saldoTotal.ToString("C2")}");
        }
        else Console.WriteLine($"Valor invalido, saldo atual: {saldoTotal.ToString("C2")}");
    }

}