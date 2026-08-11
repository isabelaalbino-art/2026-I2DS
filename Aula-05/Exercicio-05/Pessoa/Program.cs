internal class Program
{
    private static void Main(string[] args)
    {
        //Primeiro funcionario
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "Joao da Silva";
        funcionario1.IdadeAtual = 32;
        funcionario1.Salario = 2750.00;
        funcionario1.Registro = 125;

           //Segundo funcionario
        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Maria de Oliveira";
        funcionario2.IdadeAtual = 26;
        funcionario2.Salario = 2950.00;
        funcionario2.Registro = 115;

           //Primeiro funcionario
        Funcionario funcionario3 = new Funcionario();
        funcionario3.Nome = "Pedro dos Santos";
        funcionario3.IdadeAtual = 41;
        funcionario3.Salario = 3750.00;
        funcionario3.Registro = 102;

     //Exibindo funcionarios
        Console.WriteLine("=== FUNCIONARIOS ===");
        Console.WriteLine($"\nFuncionario1");
        Console.WriteLine($"Nome: {funcionario1.Nome}");
        Console.WriteLine($"Idade: {funcionario1.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario1.Registro}");
        Console.WriteLine($"Salario R$: {funcionario1.Salario:F2}");

         Console.WriteLine($"\nFuncionario1");
        Console.WriteLine($"Nome: {funcionario2.Nome}");
        Console.WriteLine($"Idade: {funcionario2.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario2.Registro}");
        Console.WriteLine($"Salario R$: {funcionario2.Salario:F2}");

         Console.WriteLine($"\nFuncionario1");
        Console.WriteLine($"Nome: {funcionario3.Nome}");
        Console.WriteLine($"Idade: {funcionario3.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario3.Registro}");
        Console.WriteLine($"Salario R$: {funcionario3.Salario:F2}");

        //Envelhecendo os funcionarios
        funcionario1.Envelhecer(13);
        funcionario2.Envelhecer(22);
        funcionario3.Envelhecer(30);

        //Exibindo as idades
        Console.WriteLine("=== APÓS ENVELHECER ===");

        Console.WriteLine($"{funcionario1.Nome} : {funcionario1.IdadeAtual}");
        Console.WriteLine($"{funcionario2.Nome} : {funcionario2.IdadeAtual}");
        Console.WriteLine($"{funcionario3.Nome} : {funcionario3.IdadeAtual}");


    }

    public class Pessoa
    {
        public string Nome {get; set;}
        public int IdadeAtual {get; set;}
        public void Envelhecer(int anos)
        {
            IdadeAtual += anos; //IdadeAtual = IdadeAtual + anos
        }
    }

    public class Funcionario : Pessoa
    {
        public double Salario {get; set;}
        public int Registro {get; set;}
    }


}