using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM FILAS (FIFO) ===");

        //1 - Cria uma fila fazia
        Queue<string> filaBanco = new Queue<string>();

        // 2- Adicionar elementos na fila
        filaBanco.Enqueue("Zuleika"); // 0
        filaBanco.Enqueue("Asdrubal"); // 1
        filaBanco.Enqueue("Pafuncio"); // 2
        filaBanco.Enqueue("Epaminondas"); // 3

        // 3 - Percorrer elementos de uma fila
        Console.WriteLine();
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Retirar um elemento da lista
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O nome chamado foi: {pessoaRetirada}");

        filaBanco.Enqueue("Lucrecia");
        Console.WriteLine();
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // Verificando se existe um determinado elemento na lista
        string procurar = "Pafuncio";
        bool achou = filaBanco.Contains(procurar);
Console.WriteLine();
        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila!");
        }
        else
        {
            Console.WriteLine($"{procurar} NÃO está na fila!");
        }
    }
}