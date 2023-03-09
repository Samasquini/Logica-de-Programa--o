public class Conversor
{
    public int HoraMinuto(int hora)
    {
        return hora * 60;
    }
    public int MinutoSegundo(int minuto)
    {
        return minuto * 60;
    }
    public ulong SegundoHora(ulong segundos)
    {
        return segundos / 3600;
    }

}