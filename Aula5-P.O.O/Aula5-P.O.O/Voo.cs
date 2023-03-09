public class Voo
{
    private DateTime dataVoo;
    private int numVoo;
    private bool[] assento = new bool[101];
    
    public int GetVoo()
    {
        return numVoo;
    }
    public DateTime GetData()
    {
        return dataVoo;
    }
    public Voo(int numVoo,DateTime dataVoo)
    {
        this.numVoo = numVoo;
        this.dataVoo = dataVoo;
    }
    public int ProximoLivre()
    {
        for(int i = 1; i < assento.Length; i++)
        {
            if (!assento[i])
            {
                return i;
            }
        }
        return 0;
    }
    public bool Verifica(int numCadeira)
    {
        if (assento[numCadeira])
        {
            return true;
        }
        return false;
    }
    public bool Ocupa(int numCadeira)
    {
        bool verificar = Verifica(numCadeira);
        if (verificar)
        {
            return false;
        }
        else
        {
            assento[numCadeira] = true;
            return true;
        }
    }
    public int Vagas()
    {
        int cont = 0;
        for (int i = 1; i < assento.Length; i++)
        {
            if (!assento[i])
            {
                cont++;
            }
        }
        return cont;
    }
}