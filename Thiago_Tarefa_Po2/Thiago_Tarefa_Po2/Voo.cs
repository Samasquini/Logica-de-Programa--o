using System.Security.Cryptography.X509Certificates;

public class Voo
{
    private int numdoVoo;
    private DateTime DatadoVoo;
    public bool[] cadeirasDoVoo = new bool[100];


    public Voo(int numdoVoo, DateTime DatadoVoo)
    {
        this.numdoVoo = numdoVoo;
        this.DatadoVoo = DatadoVoo;
    }

    public int ProximaLivre()
    {
        int proximaLivre = 1;
        for (int i = 0; i < cadeirasDoVoo.Length; i++)
        {
            if (cadeirasDoVoo[i] == false)
            {
                proximaLivre += i;
                break;
            }
        }
        return proximaLivre;
    }


    public bool Verifica(int numero)
    {
        if (cadeirasDoVoo[numero])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Ocupa(int numero)
    {
        return cadeirasDoVoo[numero] = true;
    }


    public int Vagas()
    {
        int numdecadeirasvagas = 0;
        for(int i = 1; i < cadeirasDoVoo.Length; i++)
        {
            if (cadeirasDoVoo[i] == false)
            {
                numdecadeirasvagas++;
            }
        }
        return numdecadeirasvagas;
    }


    public int GetNumDoVoo()
    {
        return this.numdoVoo;
    }


    public DateTime GetData()
    {
        return this.DatadoVoo;
    }
}

