using System;
using System.Linq;
using System.Text;
using System.Diagnostics;



class Bittris
{

    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[n][];
        bool[][] visited = new bool[n][];

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            
            string[] arrey = new string[5];
            

            arrey = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            jaggedArray[i] = Array.ConvertAll(arrey, int.Parse);
            visited[i] = new bool[jaggedArray[i].Length];
        }

        int arraynum = 0;
        int special_value = 0;
        int temp_value = 1;
        int steps = 1;
        int max_steps = 1;


        for (int i = 0; i < jaggedArray[0].Length; i++)
        {

      
            if (jaggedArray[0][i] < 0)
            {
                temp_value -= jaggedArray[0][i];

                if (temp_value > special_value)
                {
                    special_value = temp_value;

                }
                temp_value = 1;
                continue;
            }

                if (jaggedArray[arraynum][i] >= 0)
                {
                    visited[arraynum][i] = true;
                    int antiloop = arraynum;
                    int antiloop1 = i;
                 
                    int chosen = jaggedArray[arraynum][i];


                    int row_num = arraynum + 1;
                    if (row_num == n)
                    {
                        row_num = 0;

                    }
                   
                    while (true)
                    {
                       
                            if (jaggedArray[row_num][chosen] >= 0)
                            {
                             
                                chosen = jaggedArray[row_num][chosen];
                                steps++;
                                row_num++;
                            
                                if (row_num == n)
                                {
                                    row_num = 0;

                                }
                                
                                if (visited[row_num][chosen] == true)
                                {


                                    break;
                                }
                                visited[row_num][chosen] = true;
                           


                               continue;


                            }
                        
                        else
                        {

                            steps++;
                      
                            if (steps >= max_steps)
                            {

                                max_steps = steps;

                                if (steps + (-1 * jaggedArray[row_num][chosen]) > special_value)
                                {

                                    special_value = steps + (-1 * jaggedArray[row_num][chosen]);
                                }
                            }
     
                            break;
                        }

                    }
                    steps = 1;
   

                }

            if (n == arraynum)
            {
                break;
            }

        }

        Console.WriteLine(special_value);
        
        
    }


}
