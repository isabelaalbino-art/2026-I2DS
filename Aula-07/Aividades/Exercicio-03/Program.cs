internal class Program
{

    /*
    ## 🟢 Exercício 03 — Agenda Telefônica

Crie uma agenda telefônica utilizando:

```csharp
Dictionary<string, string>
```

Onde:

- A chave representa o nome.
- O valor representa o telefone.

O programa deve permitir:

1. Cadastrar um contato.
2. Pesquisar um contato pelo nome.
3. Alterar o telefone de um contato.
4. Remover um contato.
5. Exibir todos os contatos.

**Conceitos:** `Dictionary`, chave/valor, inclusão, alteração, pesquisa e remoção.

---

    */
    private static void Main(string[] args)
    {
        Console.WriteLine("=== AGENDA TELEFONICA ===");

         Dictionary<string, string> agenda = new Dictionary<string, string>();
         agenda.Add("Isabela", "(14)325698-7854");
         agenda.Add("Carlos", "(14)998698-7854");
         agenda.Add("Rafaella", "(14)985698-7846");
         agenda.Add("Betina", "(14)25498-7854");
         agenda.Add("Felipe", "(14)37698-2265");

         Console.WriteLine();
        foreach(var palavra in agenda)
        {
            Console.WriteLine($"Nome: {palavra.Key} - Número: {palavra.Value}");
        }


         string termo;
        bool chaveExiste = agenda.TryGetValue("Betina", out termo);
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"O NOME FOI ENCONTRADO: {termo}");
        } else
        {
            Console.WriteLine("O NOME NÃO FOI ENCONTRADO");
        }


         agenda["Isabela"] = "(14)99663-0278";
         Console.WriteLine();
         Console.WriteLine("ALTERANDO NÚMERO...");
        Console.WriteLine();
        foreach(var palavra in agenda)
        {
            Console.WriteLine($"Nome: {palavra.Key} - Número: {palavra.Value}");
        }
        
        agenda.Remove("Felipe");

         Console.WriteLine();
        Console.WriteLine("REMOVENDO CONTATO...");

        Console.WriteLine();
        foreach(var palavra in agenda)
        {
            Console.WriteLine($"Nome: {palavra.Key} - Número: {palavra.Value}");
        }
      
    }
}