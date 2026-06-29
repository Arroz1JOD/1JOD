using System;

class Program
{
    static void Main(string[] args)
    {
        Random gerador = new Random();
        int numeroRandom = gerador.Next(100);

        int n2;

        while (true)
        {
            Console.Write("Qual o número que a máquina sorteou: ");

            n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 == numeroRandom)
            {
                Console.WriteLine("Você acertou!");
                break;
            }
            else if (n2 > numeroRandom)
            {
                Console.WriteLine("O número sorteado é menor.");
            }
            else
            {
                Console.WriteLine("O número sorteado é maior.");
            }
        }
    }
}
