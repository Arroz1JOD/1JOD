using System;

class Program
{
    static void Main(string[] args)
    {
        int n1 = 1;
        int n2 = 0;
        int CD;

        Console.WriteLine("Qual a quantidade da sequencia que voce deseja : ");
        CD = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("------------------------------------------------");
        for (int i = 0; i < CD; i++)
        {
            int prox = n1 + n2;
            Console.WriteLine(prox);

            n1 = n2;
            n2 = prox;
        }
    }
}