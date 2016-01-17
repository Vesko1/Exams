using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajnenia
{
    class Program
    {
        static void Main(string[] args)
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



       


            bool marked = false;
            int EmptyCell = 1;

            for (int r = 0; r < 8; r++)
            {
                marked = false;
                for (int k = 7; k > -1; k--)
                {
                    
                    if (grid[k, r] == 0 && marked == false)
                    {
                        EmptyCell = k;
                        marked = true;
                        

                    }

                    if (grid[k, r] == 1 && marked == true)
                    {
                        
                        grid[EmptyCell, r] = 1;

                        grid[k, r] = 0;

                       
                        marked = false;
                       
                        k = 8;

                    }

                  
                }
            }
      
            string result = "";

            for (int r = 0; r < 8; r++)
            {
                for (int k = 0; k < 8; k++)
                {
                    result += grid[r, k];
                }

                Console.WriteLine(Convert.ToInt32(result, 2));
                result = "";

            }


        }
    }

    
}
