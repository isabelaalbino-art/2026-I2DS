internal class Program
{

    /*
    ## 🟢 Exercício 04 — Fila de Atendimento

Crie um sistema simples de atendimento utilizando:

```csharp
Queue<string>
```

Adicione inicialmente os seguintes clientes:

- João
- Maria
- Carlos
- Ana
- Pedro

O programa deve:

1. Exibir a fila.
2. Atender o primeiro cliente.
3. Informar quem foi atendido.
4. Exibir a fila restante.
5. Permitir adicionar um novo cliente.

**Conceito principal:** FIFO — First-In, First-Out.

---
    */
    private static void Main(string[] args)

    {
        Console.WriteLine("=== CLIENTES NA FILA ===");

         Queue<string> clientes = new Queue<string>();
         clientes.Enqueue("João");
         clientes.Enqueue("Maria");
         clientes.Enqueue("Carlos");
         clientes.Enqueue("Ana");
         clientes.Enqueue("Pedro");

         Console.WriteLine();
        foreach(var pessoa in clientes)
        {
            Console.WriteLine($"-{pessoa}");
        }

         string pessoaAtendida = clientes.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O NOME CHAMADO FOI: {pessoaAtendida}");

        Console.WriteLine();
        foreach(var pessoa in clientes)
        {
            Console.WriteLine($"-{pessoa}");
        }

        Console.WriteLine();
        Console.WriteLine("ENTRANDO NOVO CLIENTE...");

        clientes.Enqueue("Fernanda");
        Console.WriteLine();
       foreach(var pessoa in clientes)
        {
            Console.WriteLine($"-{pessoa}");
        }


    }
}