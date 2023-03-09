public class Juros
{
    public Juros()
    {

    }
    public double CalcularJuros(double valor, double juros)
    {
        return valor * (juros / 100);
    }
}