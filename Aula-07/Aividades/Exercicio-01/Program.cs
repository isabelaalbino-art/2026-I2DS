using System.Runtime.InteropServices;

internal class Program
{


    /*## 🟢 Exercício 01 — Cadastro de Frutas

Crie um aplicativo Console que utilize uma `List<string>` para armazenar nomes de frutas.

O programa deve:

- Adicionar inicialmente 5 frutas.
- Exibir todas as frutas cadastradas.
- Solicitar ao usuário uma nova fruta.
- Adicionar a nova fruta à lista.
- Exibir novamente a lista atualizada.

**Conceitos:** `List`, `Add`, `foreach`.

---

    */
    public class Cadastro
    {
        public string Nome {get;set;}
        public int Quantidade {get; set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== FRUTAS CADASTRADAS===");

         List<Cadastro> listaFruta = new List<Cadastro>();

         Cadastro cadastro1 = new Cadastro
         {
             Nome = "Maçã" , Quantidade = 2
         };

         Cadastro cadastro2 = new Cadastro
         {
             Nome = "Laranja" , Quantidade = 5
         };

         Cadastro cadastro3 = new Cadastro
         {
             Nome = "Melancia" , Quantidade = 8
         };

         Cadastro cadastro4 = new Cadastro
         {
             Nome = "Uva" , Quantidade = 3
         };

         Cadastro cadastro5 = new Cadastro
         {
             Nome = "Melancia" , Quantidade = 7
         };

        

         listaFruta.Add(cadastro1);
         listaFruta.Add(cadastro2);
         listaFruta.Add(cadastro3);
         listaFruta.Add(cadastro4);
         listaFruta.Add(cadastro5);

        Console.WriteLine();
         foreach (var item in listaFruta)
        {
            Console.WriteLine($" Nome: {item.Nome} - Quantidade :{item.Quantidade}");
        };

        Console.WriteLine();
        Console.WriteLine("ADICIONANDO NOVA FRUTA...");

         Cadastro cadastro6 = new Cadastro
         {
             Nome = "Goiaba" , Quantidade = 2
         };


         listaFruta.Add(cadastro6);

         Console.WriteLine();
         foreach (var item in listaFruta)
        {
            Console.WriteLine($" Nome: {item.Nome} - Quantidade {item.Quantidade}");
        }



    }
}