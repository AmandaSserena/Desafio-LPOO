public class Livro
{
    public string Titulo;
    public Autor Autor;
    public double Preco;

    public Livro(string titulo, Autor autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public Livro(string titulo, Autor autor, double preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }

    public void MostrarInfo()
    {
        Console.WriteLine("Título: " + Titulo);
        Autor.MostrarInfo();
        Console.WriteLine("Preço: " + Preco);
    }

//sobrecarga de método
    public void AplicarDesconto(double porcentagem)
    {
        Preco -= Preco * (porcentagem / 100);
    }

    public void AplicarDesconto(int valor)
    {
        Preco -= valor;
    }
}
