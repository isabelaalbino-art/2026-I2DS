internal class Program
{
    private static void Main(string[] args)
    {
        Personagem personagem1 = new Personagem("Mago", 1, 70, 50, 90, 100, 100);
        Personagem personagem2 = new Personagem("Elfo", 1, 60, 90, 75, 100, 100);
        Personagem personagem3 = new Personagem("Cavaleiro", 1, 80, 40, 60, 100, 100);

        Console.WriteLine("=== APRESENTANDO PERSONAGENS ===");

        Console.WriteLine($"Personagem 1 -");
        Console.WriteLine($"\nNome: {personagem1.Nome} | Nivel: {personagem1.Nivel} | Força: {personagem1.Forca}% | Agilidade: {personagem1.Agilidade}% | Inteligencia: {personagem1.Inteligencia}% | Vida: {personagem1.Vida} | Vida Maxima: {personagem1.VidaMaxima}");

        Console.WriteLine($"Personagem 2 -");
        Console.WriteLine($"\nNome: {personagem2.Nome} | Nivel: {personagem2.Nivel} | Força: {personagem2.Forca}% | Agilidade: {personagem2.Agilidade}% | Inteligencia: {personagem2.Inteligencia}% | Vida: {personagem2.Vida} | Vida Maxima: {personagem2.VidaMaxima}");

        Console.WriteLine($"Personagem 3 -");
        Console.WriteLine($"\nNome: {personagem3.Nome} | Nivel: {personagem3.Nivel} | Força: {personagem3.Forca}% | Agilidade: {personagem3.Agilidade}% | Inteligencia: {personagem3.Inteligencia}% | Vida: {personagem3.Vida} | Vida Maxima: {personagem3.VidaMaxima}");

        Console.WriteLine("Escolha seu personagem: ");
    }

    public class Personagem
    {      public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }
        public int VidaMaxima { get; set; }

        public Personagem(string nome, int nivel, int forca, int agilidade, int inteligencia, int vida, int vidaMaxima)
        {
            this.Nome = nome;
            this.Nivel = nivel;
            this.Forca = forca;
            this.Agilidade = agilidade;
            this.Inteligencia = inteligencia;
            this.Vida = vida;
            this.VidaMaxima = vidaMaxima;
        }
    }
}