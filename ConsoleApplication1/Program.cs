using System;

class abc
{
    public static void Main()
    {
        int rowCount = 1;
        int j;
        Console.WriteLine("enter no of rows:");
        int rows =Convert.ToInt32( Console.ReadLine());
        for(int i=rows;i>0;i--)
        {
            for(j=1;j<=i;j++)
            Console.Write(" ");

            for (j = 1; j <= rowCount; j++) {
                Console.Write((Char)(rowCount + 64) + " ");
            }
            rowCount++;                
            Console.WriteLine();
            

        }
        Console.ReadKey();
    }
}