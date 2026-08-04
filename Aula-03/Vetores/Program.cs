internal class Program
{
    private static void Main(string[] args)
    {
        /*  Vetores e matrizes 
        Vetor -> é uma estrutura de dados utilizada para armazenar varios valores de um mesmo tipo dentro de uma unica variavel

        sintaxe: tipo[] nome_vetor = new tipo[tamanho]; 

        */

        /* Iniciar um vetor -> lista de frutas */

        string[] listaFrutas = {"Maçã", "Manga", "Morango", "Melancia", "Melão"};

        Console.WriteLine("Acessar o terceiro elemneto da lista: ");
        Console.WriteLine(listaFrutas [2]);

        Console.WriteLine("Alterar o segundo elemento da lista: ");
        listaFrutas[1] = "Banana";

        for (int indice = 0; indice < listaFrutas.Count(); indice++)
        {

            Console.WriteLine(listaFrutas[indice]);
        }


        /******************************************************************************************/

        foreach(string fruta in listaFrutas) //percorre listas   
        {
            Console.WriteLine(fruta);
        }
        
        /***************************************************************************************/
        



}
}