using System;

class Program
{
    static int Jakojäännös(int a, int b)
    {
        return a % b;
    }

    static void Main()
    {
        Console.Write("Syötä ensimmäinen numero: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Syötä toinen numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        int jakojäännös = Jakojäännös(numero1, numero2);
        Console.WriteLine($"Jakojäännös: {jakojäännös}");
    }
}