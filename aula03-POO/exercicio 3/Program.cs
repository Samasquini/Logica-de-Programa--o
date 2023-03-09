public class Program
{
    static void Main(string[] args)
    {
        Conversor n = new Conversor();
        Console.Write("Digite a hora: ");
        var a = int.TryParse(Console.ReadLine(), out var hora);
        Console.WriteLine($"Minutos: {n.HoraMinuto(hora)}, Segundos: {n.MinutoSegundo(n.HoraMinuto(hora))}.");

        Console.Write("Digite os segundos: ");
        a = ulong.TryParse(Console.ReadLine(), out var segundos);
        Console.WriteLine($"Horas: {n.SegundoHora(segundos)}.");
    }
}