using System;
using System.Linq;
using System.Text;
using System.Diagnostics;



class Bittris
{
    
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());

        string[,] grid = new string[3, 3];

        grid[0, 0] = "RED";  grid[1, 0] = "BLUE"; grid[2, 0] = "RED"; grid[0, 1] = "BLUE";  grid[1, 1] = "GREEN";
        grid[1, 2] = "BLUE"; grid[2, 1] = "BLUE"; grid[2, 2] = "RED"; grid[0, 2] = "RED";
        int x = 1; 
        int y = 1;

        int direction = 0;

        string[] lines = new string[N];

        for (int i = 0; i < N; i++)
        {
            lines[i] = Console.ReadLine();

        }

        for (int i = 0; i < lines.Length; i++)
        {

            int ha = lines[i].Length;

            for (int q = 0; q < ha; q++)
            {
                if (lines[i][q] == 'L')
                {
                    direction++;

                    if (direction == 3)
                    {
                        direction = -1;

                    }
                  
                }
                if (lines[i][q] == 'R')
                {
                    direction--;

                    if (direction < -1)
                    {
                        direction *= -1;

                    }
                }

                if (lines[i][q] == 'W')
                {
                    
                    if (direction == 0)
                    {

                        x--;

                        if (x < 0)
                        {
                            x = 2;
                        }
                    
                    
                    }

                    if (direction == 1)
                    {

                        y--;

                        if (y < 0)
                        {
                            y = 2;

                        }


                    }

                    if (direction == 2)
                    {
                        x++;

                        if (x > 2)
                        {
                            x = 0;
                        }
                    
                    
                    }

                    if (direction == -1)
                    {
                        y++;

                        if (y > 2)
                        {
                            y = 0;

                        }
                    
                    
                    
                    }

                }


            }

            Console.WriteLine(grid[x,y]);
           x = 1;
           y = 1;
        }
         
            




    }


}
