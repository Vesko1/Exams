using System;

class Pillars
{
    static void Main()
    {



        int[,] grid = new int[8, 8];


        int input;

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            input = int.Parse(Console.ReadLine());

            for (int p = grid.GetLength(1) - 1; p >= 0; p--)
            {

                grid[i, p] = input % 2;
                input = input / 2;

            }
        }

        int column = 0;
        int left = 0;
        int right = 0;
        int pillar = 0;
        int match = 0;
        int one = 1;
        int bestmatch = 0;
        int bestcolumn = 0;
        int bestpillar = 20;

        while (pillar <= 7)
        {
            for (int i = 0; i < pillar; i++)
            {
                for (int m = 0; m < 8; m++)
                {
                    int temp = (int)grid[m, i];
                   if (temp == one)
                    {
                        left++;
                    }
                }
            }
            for (int i = pillar + 1; i < 8; i++)
            {
                for (int m = 0; m < 8; m++)
                {
                    int temp = (int)grid[m, i];

                    if (temp == one)
                    {
                        right++;
                    }
                }
            }
            if (left == right && pillar < bestpillar)
            {

                bestpillar = pillar;
                match = right;
                
            }
            left = 0;
            right = 0;
            pillar++;
        }

        if (bestpillar < 20)
        {
            Console.WriteLine(7 - bestpillar);
            Console.WriteLine(match);
        }
        else
        {
            Console.WriteLine("No");
        }
               
    }

    }

