using System;

public class Toolbox
{
    public static string[] vika()
    {
        int i = 0;
        string[] kampe = new string[2];

        while (i < 2)
        {
            System.Console.WriteLine($"Skriv spelar {i + 1} namn");
            kampe[i] = Console.ReadLine();
            i++;
            Console.Clear();
        }

        return kampe;
    }

    public static void slags(string[] kampe)
    {
        Random generator = new Random();
        int r = generator.Next(0, 10);
        int[] hp = new int[2];
        for (int i = 0; i < 2; i++) { hp[i] = 100; }
        System.Console.WriteLine($"Spelare 1 har {hp[0]} och spelare 2 har {hp[1]}");
        Console.ReadLine();
        Console.Clear();

        //while (hp)
    }
}