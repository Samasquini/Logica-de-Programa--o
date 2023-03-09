using System;
class att
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a área em metros quadrados: ");
        int metros = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calc(metros) + " Lata(s) de tinta.");
        double latas = calc(metros);
        Console.WriteLine("Total = " + preco(latas).ToString("C2"));

        
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