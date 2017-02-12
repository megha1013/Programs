using System;

class abc
{
    public static void Main()
    {
        int i, j;
        for(i=1;i<=4;i++)
        {
            for(j=1;j<=7-i;j++)
            Console.Write(" ");

            for (j = 1; j <= i; j++)
            
                Console.Write((Char)(i+64) + "");
                Console.WriteLine();
            
            Console.ReadKey();

        }
    }
}