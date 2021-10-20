using System;

public class Toolbox
{
    public static int kämpe()
    {
        int i = 0;
        int ii = 0;
        while (i == 1)
        {

            string check = Console.ReadLine();
            check = Console.ReadLine().ToLower();
            if (check == "a")
            {
                ii = 1;
                i = 1;
            }
            if (check == "b")
            {
                ii = 2;
                i = 1;
            }
        }
        return ii;
    }

}