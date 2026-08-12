internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");
        // Sintaxe Dictonary<chave, valor>
        //                  <>
        
        Dictionary<string, string> dicionario = new Dictionary<string, string>();
        // Adicionar elementos no dicionario
        dicionario.Add("Casa","Construção destinada à moradia.");
        dicionario.Add("Livro","Conjunto de páginas encadernadas contendo textos, imagens ou informações.");
        dicionario.Add("Amizade","Relação de afeto, confiança e companheirismo entre pessoas.");
        dicionario.Add("Escola","Instituição destinada ao ensino e à educação de crianças, jovens ou adultos.");

        // 3 - Percorrer todos os elementos de eum dicionario
        Console.WriteLine();
        foreach(var palavra in dicionario)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

        //Alterar um elemento do dicionario
        dicionario["Casa"] = "Construção destinada à moradia definitiva ou temporaria.";
        Console.WriteLine();
        foreach(var palavra in dicionario)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

        //Verificar se uma chave (key) dentro do dicionario
        string termo;
        bool chaveExiste = dicionario.TryGetValue("Amizade", out termo);
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"A palavra foi encontrada: {termo}");
        } else
        {
            Console.WriteLine("A palavra mão foi encontrada no diciionário");
        }

        // 6 -Excluir um item do dicionario
        dicionario.Remove("Casa");

        Console.WriteLine();
        foreach(var palavra in dicionario)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

        // 7 - Ordenar um dicionario por chave
         var DicionarioOrdenado = dicionario.OrderBy(i => i.Key); // (=>) - tal que 
        Console.WriteLine();
        foreach(var palavra in DicionarioOrdenado)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

    }
}