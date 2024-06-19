public class Principal{

    public static void Main(String[] args){
        Autor autor = new Autor("J.K. Rowling", "Reino Unido");
        Livro livro = new Livro("Harry Potter", autor, 40.0);
        livro.MostrarInfo();
        livro.AplicarDesconto(10);
        livro.MostrarInfo();
        livro.AplicarDesconto(5.0);
        livro.MostrarInfo();
    }

}

