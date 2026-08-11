internal class Program
{
    private static void Main(string[] args)
    {
        //Primeiro livro
        Livro livro1 = new Livro();
        livro1.Titulo = "O Senhor dos Anéis";
        livro1.Autor = "J.R.R Tolkien";
        livro1.Editora = "HarperCollins";
        livro1.AnoLancamento = 1954;

        //Segundo livro
         Livro livro2 = new Livro();
        livro2.Titulo = "Harry Potter e a Pedra Filosofal";
        livro2.Autor = "J.K Rowling";
        livro2.Editora = "Rocco";
        livro2.AnoLancamento = 1997;

        //Terceiro livro
         Livro livro3 = new Livro();
        livro3.Titulo = "Dom Casmurro";
        livro3.Autor = "Machado de Assis";
        livro3.Editora = "Garnier";
        livro3.AnoLancamento = 1899;

        //Exibindo os livros na tela
        Console.WriteLine("==== LIVROS ====");
        Console.WriteLine($"\nLivro 01: {livro1.Titulo} | Ator: {livro1.Autor}");
        Console.WriteLine($"Livro 02: {livro2.Titulo} | Ator: {livro2.Autor}");
        Console.WriteLine($"Livro 03: {livro3.Titulo} | Ator: {livro3.Autor}");


    }

    public class Livro
    {
        public string Titulo {get; set;}
        public string Autor {get; set;}
        public string Editora {get; set;}
        public int AnoLancamento {get; set;}

    }
}