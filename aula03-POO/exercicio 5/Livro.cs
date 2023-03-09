public class Livro
{
    public string titulo;
    public string nomeDoAutor;
    public string anoDeLancamento;
    public bool status;
    public string codigoIdentificador;

    public Livro()
    {

    }
    public Livro(string titulo, string nomeDoAutor, string anoDeLancamento, string codigoIdentificador)
    {
        this.titulo = titulo;
        this.nomeDoAutor = nomeDoAutor;
        this.anoDeLancamento = anoDeLancamento;
        this.status = true;
        this.codigoIdentificador = codigoIdentificador;
    }
}