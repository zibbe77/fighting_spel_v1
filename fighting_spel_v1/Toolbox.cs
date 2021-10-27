using System;

public class Toolbox
{
    public static string[] vika()
    {
        int i = 0;
        string[] kampe = new string[2];

        while (i < 2)
        {
            System.Console.WriteLine($"Skriv spelar {i + 1} namn (Måste var mindre än 16)");
            kampe[i] = Console.ReadLine();
            if (kampe[i] != "" && kampe[i].Length < 16)
            {
                i++;
            }
            else { System.Console.WriteLine("Du skriv inte något eller var det för långt"); }
            Console.Clear();
        }

        return kampe;
    }

    public static void slags(string[] kampe)
    {
        Random generator = new Random();
        int[] hp = new int[2];
        for (int i = 0; i < 2; i++) { hp[i] = 100; }
        System.Console.WriteLine($"Spelare 1 har {hp[0]} och spelare 2 har {hp[1]}");
        Console.ReadLine();
        Console.Clear();

        while (hp[0] > 0 && hp[1] > 0)
        {
            for (int i = 0; i < 2; i++)
            {
                int r = generator.Next(0, 10);
                hp[i] -= r;
                System.Console.WriteLine($"{kampe[i]} tog {r} skada");
                System.Console.WriteLine(hp[i]);
                Console.ReadLine();
            }
        }
        Console.Clear();
        if (hp[0] < hp[1])
        {
            System.Console.WriteLine($"{kampe[1]} van");
        }
        else { System.Console.WriteLine($"{kampe[0]} van"); }
        Console.ReadLine();
    }
}