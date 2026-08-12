internal class Program
{

    /*
    ## 🟢 Exercício 02 — Cadastro de Alunos

Crie uma classe `Aluno` com as propriedades:

- `Nome`
- `Idade`

Cadastre 5 alunos utilizando uma `List<Aluno>`.

O programa deve:

1. Exibir todos os alunos.
2. Permitir alterar a idade de um aluno.
3. Permitir remover um aluno pelo nome.
4. Exibir a lista final.

**Conceitos:** `List<T>`, objetos, pesquisa, alteração e remoção.

---
    */


    public class Aluno
    {
        public string Nome {get;set;}
        public int Idade {get;set;}

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== ALUNOS ===");

         List<Aluno> listaAlunos = new List<Aluno>();

         Aluno aluno1 = new Aluno
         {
             Nome = "Ana" , Idade = 15
         };
          Aluno aluno2 = new Aluno
         {
             Nome = "Carlos" , Idade =  16
         };
          Aluno aluno3 = new Aluno
         {
             Nome = "Maria" , Idade = 15
         };
         Aluno aluno4 = new Aluno
         {
             Nome = "Isabela" , Idade = 16
         };
         Aluno aluno5 = new Aluno
         {
             Nome = "Viccenzo" , Idade = 15
         };

         listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2); 
        listaAlunos.Add(aluno3);
        listaAlunos.Add(aluno4);
        listaAlunos.Add(aluno5);

        Console.WriteLine();
         foreach (var item in listaAlunos)
        {
            Console.WriteLine($"Nome: {item.Nome} - Idade: {item.Idade}");
        }
        listaAlunos[4].Idade = 19;
    
        Console.WriteLine();
        Console.WriteLine("ALTERANDO IDADE...");

        Console.WriteLine();
         foreach (var item in listaAlunos)
        {
            Console.WriteLine($"Nome: {item.Nome} - Idade: {item.Idade}");
        }

        listaAlunos.Remove(aluno1);

        Console.WriteLine();
        Console.WriteLine("REMOVENDO ALUNO...");

        Console.WriteLine();
         foreach (var item in listaAlunos)
        {
            Console.WriteLine($"Nome: {item.Nome} - Idade: {item.Idade}");
        }





       

         
    }
}