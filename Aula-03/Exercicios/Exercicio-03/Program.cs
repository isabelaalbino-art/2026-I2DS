internal class Program
{
    private static void Main(string[] args)
    {
      int nota1;
      int nota2;
      int nota3;
      string nome;

        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite a primeira nota: ");
        nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota nota: ");
        nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        nota3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Olá aluno(a) " + nome);

        double resultado = 0;
        double solucao = 0;
        resultado = nota1 + nota2 + nota3 ;
        solucao = resultado / 3;

        Console.WriteLine("Sua média é:" + solucao);

        if(solucao >= 7)
        {
            Console.WriteLine("Situação: Aprovado!");
        }if(solucao >= 5 && solucao < 7)
        {
            Console.WriteLine("Situação: Recuperção");

        }
        if(solucao < 5)
        {
            Console.WriteLine("Situação: Reprovado");
            
        }


    }
}