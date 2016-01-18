using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int innerDots = (n / 2 - 1);
        int outerdots = 0;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new String('.', outerdots));
            Console.Write("\\");
            Console.Write(new String('.', innerDots));
            Console.Write("|");
            Console.Write(new String('.', innerDots));
            Console.Write("/");
            Console.Write(new String('.', outerdots));
           
            Console.WriteLine();
            
            innerDots--;
            outerdots++;
        }
        Console.Write(new String('-', n / 2));
        Console.Write('*');
        Console.Write(new String('-', n / 2));
        Console.WriteLine();


        innerDots = 0;
        outerdots = (n / 2 - 1);

        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new String('.', outerdots));
            Console.Write("/");
            Console.Write(new String('.', innerDots));
            Console.Write("|");
            Console.Write(new String('.', innerDots));
            Console.Write("\\");
            Console.Write(new String('.', outerdots));

            Console.WriteLine();

            innerDots++;
            outerdots--;
        }
    }
}