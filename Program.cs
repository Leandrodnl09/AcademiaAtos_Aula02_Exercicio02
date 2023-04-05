namespace Aula02Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
            int numero1 = 10;
            int numero2 = 20;
            int numero3 = 30;
            int numero4 = 50;

            double media = ((double)numero1 + (double)numero2 + (double)numero3 + (double)numero4) / 4;
            Console.WriteLine("A média aritmética dos 4 números é: " + media);
        }
    }
}