using System;



class Program
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());

        //long result = int.Parse(Console.ReadLine());
        long b = 0;

        for (int i = 0; i < N; i++)
        {
            
            long result = long.Parse(Console.ReadLine());

            b ^= result;
        }

        Console.WriteLine(b);
    }
}
