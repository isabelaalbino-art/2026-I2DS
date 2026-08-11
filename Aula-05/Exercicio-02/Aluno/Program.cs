internal class Program
{
    private static void Main(string[] args)
    {
        //Primeiro livro
        Aluno Aluno1 = new Aluno();
        Aluno1.Nome = "Isabela";
        Aluno1.RM = 4569;
        Aluno1.Nascimento = new DateOnly(2009, 06, 12); //ano, mes ,dias
        Aluno1.Email = "isabela";

         //Segundo livro
        Aluno Aluno2 = new Aluno();
        Aluno2.Nome = "joao";
        Aluno2.RM = 4889;
        Aluno2.Nascimento = new DateOnly(2010, 01, 02);
        Aluno2.Email = "joao";

         //Terceiro livro
        Aluno Aluno3 = new Aluno();
        Aluno3.Nome = "maria";
        Aluno3.RM = 5669;
        Aluno3.Nascimento = new DateOnly(2009, 08, 4);
        Aluno3.Email = "maria";


        //Exibindo os Alunos na tela
        Console.WriteLine("==== ALUNOS ====");
        Console.WriteLine($"\nAluno 01: {Aluno1.Nome} | RM: {Aluno1.RM}");
        Console.WriteLine($"Aluno 02: {Aluno2.Nome} | RM: {Aluno2.RM}");
        Console.WriteLine($"Aluno 03: {Aluno3.Nome} | RM: {Aluno3.RM}");


    }

    public class Aluno
    {
        public string Nome {get; set;}
        public int  RM {get; set;}
        public DateOnly Nascimento {get; set;}
        public string Email {get; set;}

    }
}