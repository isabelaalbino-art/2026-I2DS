internal class Program
{
    private static void Main(string[] args)
    {
       /*
          Sintaxe:
              Enquanto uma condição for verdadeira 
         
                    execute um conjunto de comandos

            for -> Quando sabemos a quantidade de repetições 
            while -> Quando a repetição depende de uma condição.
            do...while -> Quando precisa executar ao menos uma vez o bloco de código
       
       */


       /* Laço for: imprimir número de 1 até o 10*/
       Console.WriteLine("Imprimir numeros de 1 até 10 utilizando o laço for.");
// i = nome da variavel
        for(int numero = 1; numero <= 10; numero ++)
        {
            Console.WriteLine(numero);
            
        }

         /* Laço for: contagem regressiva de 10 até 1*/
         Console.WriteLine("Imprimir contagem regressiva");
// i = nome da variavel
        for(int numero = 10; numero >= 0; numero --)
        {
            Console.WriteLine(numero);
        }


        /*****************************************************************/
         Console.WriteLine("Imprimir numeros de 1 até 10 utilizando o laço while");

         int contador =1;
        while (contador <= 10)
        {
              Console.WriteLine(contador);
            contador ++;
        }

        /* Solicitar a senha até acertar  */
        
        string senha = "";
        while (senha !="2444") 
        // "!=" -> comparação 
        {
            Console.Write("Digite a senha: ");

            senha = Console.ReadLine();

        }
        Console.WriteLine("Acesso Permitido!");



/************************************************************************************/

    int num;
        do
        {

            Console.WriteLine("Digite um número positivo :");
            num = int.Parse(Console.ReadLine());

        }while (num <=0 );




    }
}