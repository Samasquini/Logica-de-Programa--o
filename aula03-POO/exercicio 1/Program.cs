public class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta("Matheus", 0);
        conta.Sacar(100);
        conta.Deposito(-100);
        conta.Deposito(100);
        conta.Sacar(50);
    }
}