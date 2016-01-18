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


            int row;
            int column;
            int points = 0;

            int[,] grid = new int[8, 16];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                int input = int.Parse(Console.ReadLine());

                for (int p = grid.GetLength(1) - 1; p >= 0; p--)
                {

                    grid[i, p] = input % 2;
                    input = input / 2;

                }
            }




          


            for (int i = 7; i > -1; i--)
            {


                for (int a = 0; a < 8; a++)
                {

                 
                    if (grid[a, i] == 1)
                    {


                        grid[a, i] = 0;
                        // moving implementaion 


                  

                        int OneFound = 0;
                        int NotFound = 1;
                        int flight = 0;
                        int surround = 0;
                        row = a;
                        column = i;


                   
                        while (true)
                        {



                            if (row > 0)
                            {
                            
                                if (column == 15)
                                {
                                    NotFound = 0;
                                    flight++;
                                    break;

                                }
                              
                                int mover = row;

                                for (int d = 0; d < mover; d++)


                                
                                {

                                  

                                    if (grid[--row, ++column] == 1)
                                    {

                                        OneFound = 1;
                                        grid[row, column] = 0;
                                        surround++;
                                        flight++;
                                      
                                        break;
                                    }

                                    if (column == 15)
                                    {

                                        break;
                                        NotFound = 0;
                                    }
                              

                                    flight++;


                                }
                            }

                            if (OneFound == 1)
                            {
                                break;
                            }
                            if (NotFound == 0)
                            {
                            
                                break;
                            }

                            if (row == 0)
                            {
                                // int mover = 8;


                                if (column == 15)
                                {
                                    flight++;
                                    break;
                                    NotFound = 0;
                                }


                                for (int t = 0; t < 7; t++)
                                {
                                    if (grid[++row, ++column] == 1)
                                    {

                                        OneFound = 1;
                                        grid[row, column] = 0;
                                        surround++;
                                        flight++;
                                      
                                        break;
                                    }

                           

                                    if (column == 15)
                                    {
                                        NotFound = 0;
                                        break;

                                    }
                                    flight++;


                                    if (row == 7)
                                    {
                                        NotFound = 0;
                                        break;

                                    }



                                }


                            }

                            if (OneFound == 1)
                            {
                                break;
                            }

                            if (NotFound == 0)
                            {
                             
                                break;

                            }

                            if (row == 7)
                            {
                        
                                if (column == 15)
                                {
                                    flight++;
                                    break;
                                    NotFound = 0;
                                }
                               
                                for (int y = 0; y < 6; y++)
                                {
                                    if (grid[--row, ++column] == 1)
                                    {

                                        OneFound = 1;
                                        grid[row, column] = 0;
                                        surround++;
                                        flight++;
                                      
                                        break;
                                    }

                             

                                    if (column == 15)
                                    {

                                        break;
                                        NotFound = 0;
                                    }

                                    flight++;


                                }




                            }

                            if (OneFound == 1)
                            {
                                break;
                            }
                            if (NotFound == 0)
                            {
                                break;
                               
                            }

                        }



                        


                        if (OneFound == 1)
                        {


                           

                            if (column > 0 && row > 0)
                            {
                                int row1 = row;
                                int column1 = column;

                                if (grid[--row1, --column1] == 1)
                                {

                                    surround++;
                                    grid[row1, column1] = 0;



                                }
                            }

                            // checking for top-centar 2

                            if (row > 0)
                            {
                                int row1 = row;
                                int column1 = column;

                                if (grid[--row1, column1] == 1)
                                {

                                    surround++;
                                    grid[row1, column1] = 0;


                                }
                            }



                            // checking for top-right 3

                            if (row > 0 && column < 15)
                            {
                                int row1 = row;
                                int column1 = column;

                                if (grid[--row1, ++column1] == 1)
                                {

                                    surround++;
                                    grid[row1, column1] = 0;
                                    //Console.WriteLine("top - right");

                                }
                            }


                            // checking for left-center 4

                            if (column > 0)
                            {
                                int row1 = row;
                                int column1 = column;

                                if (grid[row1, --column1] == 1)
                                {

                                    surround++;
                                    grid[row1, column1] = 0;
                               
                                }
                            }


                            if (row < 7 && column > 0)
                            {
                                int row1 = row;
                                int column1 = column;

                                if (grid[++row1, --column1] == 1)
                                {

                                    surround++;
                                    grid[row1, column1] = 0;
                                    // Console.WriteLine("left - down");

                                }
                            }


                            // checking for down-center 6

                            if (row < 7)
                            {
                                int row1 = row;
                                int column1 = column;

                                if (grid[++row1, column1] == 1)
                                {

                                    surround++;
                                    grid[row1, column1] = 0;
                                    // Console.WriteLine("down - center");

                                }
                            }




                            // checking for down-right 7

                            if (row < 7 && column < 15)
                            {
                                int row1 = row;
                                int column1 = column;

                                if (grid[++row1, ++column1] == 1)
                                {

                                    surround++;
                                    grid[row1, column1] = 0;
                                    // Console.WriteLine("down-right");

                                }
                            }



                            // checking for right center 7

                            if (column < 15)
                            {
                                int row1 = row;
                                int column1 = column;

                                if (grid[row1, ++column1] == 1)
                                {

                                    surround++;
                                    grid[row1, column1] = 0;
                                    //  Console.WriteLine("right - center");

                                }
                            }




                        }



                        points += (flight * surround);

                    }
                    //grid[i, a] = 0;
                }


            }






            int won = 1;


            for (int i = 0; i < grid.GetLength(0); i++)
            {


                for (int a = 8; a < grid.GetLength(1); a++)
                {
                    if (grid[i, a] == 1)
                    {
                        won = 0;
                    }

                    //Console.Write(grid[i, a] + " ");
                }

                //Console.WriteLine();
            }

            if (won == 1)
            {
                Console.WriteLine("{0} Yes", points);

            }
            else
            {
                Console.WriteLine("{0} No", points);

            }


        }
    }

    
}
