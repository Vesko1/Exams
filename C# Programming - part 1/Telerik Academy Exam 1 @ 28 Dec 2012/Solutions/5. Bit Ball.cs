namespace DiamondTrolls
{
    using System;

    public class Diamonds
    {
        public static void Main()
        {

            int[,] grid = new int[8, 8];


            int input;

            int[] numbers = new int[16];


            for (int i = 0; i < 16; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            int even = 0;
            int odd = 8;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                input = numbers[even];

                for (int p = grid.GetLength(1) - 1; p >= 0; p--)
                {

                    grid[i, p] = input % 2;
                    input = input / 2;

                }

                even++;
            }


            for (int i = 0; i < grid.GetLength(0); i++)
            {
                input = numbers[odd];
                odd++;
                for (int p = grid.GetLength(1) - 1; p >= 0; p--)
                {

                    int x = input % 2;
                    if (grid[i, p] == 0)
                    {
                        grid[i, p] = input % 2;


                        if (grid[i, p] == 1)
                        {

                            grid[i, p] = 2;
                        }
                    }

                    if (grid[i, p] == 1 && x == 1)
                    {
                        grid[i, p] = 0;
                    }


                    input = input / 2;


                }


            }


            int number_top_team = 0;
            int number_bottom_team = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int r = 7; r > -1; r--)
                {

                    if (grid[r, i] == 2)
                    {

                        break;

                    }
                    if (grid[r, i] == 1)
                    {
                        number_top_team++;
                        break;

                    }




                }
            }


       
            for (int i = 0; i < 8; i++)
            {
                for (int r = 0; r < 8; r++)
                {



                    if (grid[r, i] == 1)
                    {

                        break;

                    }
                    if (grid[r, i] == 2)
                    {
                        number_bottom_team++;
                        break;

                    }



                }
            }
            


            Console.WriteLine("{0}:{1}", number_top_team, number_bottom_team);
              

        }
    }
}
