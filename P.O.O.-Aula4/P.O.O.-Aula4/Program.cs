public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor: R$");
        var a = double.TryParse(Console.ReadLine(), out var valor);
        Console.Write("Digite o juros: ");
        var b = double.TryParse(Console.ReadLine(), out var juros);

        Juros calcJuros = new Juros();
        double cal = calcJuros.CalcularJuros(valor, juros);
        Console.WriteLine($"O valor do juros é de {cal.ToString("C2")}." +
            $"\nE o valor total é de {(cal + valor).ToString("C2")}.");
    }
}