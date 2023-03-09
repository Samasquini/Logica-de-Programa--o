using System;
class Ingre
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a data:");
        var a = DateTime.TryParse(Console.ReadLine(), out var dt);
        if (Ver_Aniver_Com_Intervalo(dt,4,59))
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }
    static bool Ver_Aniver_Com_Intervalo(DateTime DtAniversario, int idade1, int idade2)
    {
        DateTime DtAtual = DateTime.Now;

        int anoAniversario = DtAniversario.Year;
        int mesAniversario = DtAniversario.Month;
        int diaAniversario = DtAniversario.Day;

        int anoAtual = DtAtual.Year;
        int mesAtual = DtAtual.Month;
        int diaAtual = DtAtual.Day;

        int anos = anoAtual - anoAniversario;
        if (anos > idade1 && anos < idade2) {return true;}
        if (anos == idade1 || anos == idade2)
        {
            if (mesAniversario < mesAtual) { return true; }
            else if (mesAniversario == mesAtual)
            {
                if (diaAniversario <= diaAtual) { return true; }
                else return false;
            }
            else return false;
        }
        return false;
    }
}