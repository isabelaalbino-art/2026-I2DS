internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALAHNDO COM PILHAS ( FILO ) ===");
        
      // 1 - Criar uma nova pilha vazia 
      Stack<string> pilhaLivros = new Stack<string>();

      // 2 - Adicionar elementos em uma pilha
      pilhaLivros.Push("Dom Quixote");  
      pilhaLivros.Push("O morro dos ventos uivantes");
      pilhaLivros.Push("O cortiço");  

      //Percprrer todos os elementos de uma pilha
      Console.WriteLine();
      foreach(var item in pilhaLivros)
        {
            Console.WriteLine(item);
        }

        // 4 - Remover um elemento da pilha
       string livroRemovido = pilhaLivros.Pop(); // pop remove o primeiro elemento da pilha 
       Console.WriteLine();
       Console.WriteLine($"O livro retirado foi: {livroRemovido}");

       pilhaLivros.Push("Dom Casmurro");
       Console.WriteLine();
       Console.WriteLine();
       foreach(var item in pilhaLivros)
        {
            Console.WriteLine(item);
        }


      
        }
}