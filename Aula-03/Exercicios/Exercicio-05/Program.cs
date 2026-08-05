internal class Program
{
    private static void Main(string[] args)
    {
        
        string produto;;
        string preco;
        string encontrar;

       Console.WriteLine("Cadastrar produtos!");

       Console.WriteLine("Produto: ");
        produto = Console.ReadLine();

          Console.WriteLine("Preços: ");
        preco = Console.ReadLine();

        string[] listaProdutos = {" ", " ", " ", " ", "  "}; 
        string[] precoProdutos = {" ", " ", " ", " ", "  "};

        for (int i = 0; i < listaProdutos.Length; i++)
        {
               Console.WriteLine("Produto: ");
        produto = Console.ReadLine();

          Console.WriteLine("Preços: ");
        preco = Console.ReadLine();

        listaProdutos[i] = produto;
         precoProdutos[i] = preco;
        }
        Console.WriteLine("Produtos cadatrados com sucesso!");

        Console.WriteLine("Digite o produto para encontra-lo: ");
        encontrar = Console.ReadLine();


        if (listaProdutos[i] == encontrar)
         {
            Console.WriteLine("Produto encontrado!");
            Console.WriteLine("Produto: " + listaProdutos[i]);
Console.WriteLine("Preço: " + precoProdutos[i]);   

        }

       





            
        





     


    
    }

}