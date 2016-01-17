using System;
using System.Linq;
using System.Numerics;
using System.Text;


class Bittris
{
  
    static void Main()
    {

        int width = int.Parse(Console.ReadLine());


        int[,] grid = new int[8, width];


        int input;

        for (int i = 0; i < 8; i++)
        {
            input = int.Parse(Console.ReadLine());

            for (int p = grid.GetLength(1) - 1; p >= 0; p--)
            {

                grid[i, p] = input % 2;
                input = input / 2;

            }
        }





        string commands = Console.ReadLine();

        while (commands != "stop")
        {

            if (commands == "left")
            {
                                
                int row = int.Parse(Console.ReadLine());
                if (row < 0)
                { row = 0; }

                if (row > 7)
                { row = 7; }


                int column = int.Parse(Console.ReadLine());
                if (column < 0 )
                { column = 0; }

                if (column > width-1)
                { column = width-1; }

                int mover = 99;

                for (int i = 0; i <= column; i++)
                {

                    if (grid[row, i] == 0 && mover == 99)
                    {
                        mover = i;

                    }


                    if (grid[row, i] == 1 && mover != 99)
                    {

                        grid[row, mover] = 1;
                        grid[row, i] = 0;
                        mover = 99;
                        i = 0;

                    }



                }
            }

            if (commands == "right")
            {
                int row2 = int.Parse(Console.ReadLine());
                if (row2 < 0)
                { row2 = 0; }

                if (row2 > 7)
                { row2 = 7; }


                int column2 = int.Parse(Console.ReadLine());
                if (column2 < 0)
                { column2 = 0; }

                if (column2 > width-1)
                { column2 = width - 1; }

                int mover = 99;

                for (int w = grid.GetLength(1) - 1; w >= column2; w--)
                {

                    if (grid[row2, w] == 0 && mover == 99)
                    {
                        mover = w;

                    }


                    if (grid[row2, w] == 1 && mover != 99)
                    {

                        grid[row2, mover] = 1;
                        grid[row2, w] = 0;
                        mover = 99;
                        w = grid.GetLength(1) - 1;

                    }

                }


            }

            if (commands == "reset")
            {

                // moving all elements to the left side
                int mover = 99;

                for (int r = 0; r < 8; r++)
                {
                    for (int k = 0; k < grid.GetLength(1); k++)
                    {
                        if (grid[r, k] == 0 && mover == 99)
                        {
                            mover = k;

                        }


                        if (grid[r, k] == 1 && mover != 99)
                        {

                            grid[r, mover] = 1;
                            grid[r, k] = 0;
                            mover = 99;
                            k = 0;

                        }

                    }

                    mover = 99;

                }

            }

            commands = Console.ReadLine();


        }






        StringBuilder digitnumber = new StringBuilder();

        BigInteger sum = 0;

      //  int columns = 0;

        for (int r = 0; r < 8; r++)
        {
         
            for (int k = 0; k < grid.GetLength(1); k++)
            {
                digitnumber.Append(grid[r, k]);

            
            }
            sum += Convert.ToInt64(digitnumber.ToString(), 2);
            digitnumber.Clear();

        }

        int max_column = 0;

        int counter = 0;

        for (int q = 0; q < grid.GetLength(1); q++)
        {
            

            for (int t = 0; t < 8; t++)
            {

                if (grid[t,q] == 1)
                {
                    continue;
                }
                counter++;

                if (counter == 8)
                {
                    max_column++;
                }
                
            }
            counter = 0;
         
        }





  


        BigInteger result = max_column * sum;


        // Console.WriteLine(sum);
        Console.WriteLine(result);



    }



}
