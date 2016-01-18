using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace TryAndDelete2
{
    class Program
    {


        static void Main(string[] args)
        
        {
            
            string text = Console.ReadLine();

            List<int> myInts_2 = new List<int>(Array.ConvertAll(Console.ReadLine().Split(','), int.Parse));

            int Friends = int.Parse(Console.ReadLine()) + 1;

            string[] a = Console.ReadLine().Split();



            string[] numbers = text.Split(',');

            int[] myInts = Array.ConvertAll(numbers, int.Parse);

            int HighestPoints = -1;
            int Player = -1;


            for (int i = 0; i < myInts.Length; i++)
            {
                if (myInts[i] <= 21)
                {
                    if (myInts[i] == HighestPoints)
                    {
                        Player = -1;
                        continue;
                    }

                    if (myInts[i] > HighestPoints)
                    {
                        HighestPoints = myInts[i];
                        Player = i;
                    }
                }

            }
            if (Player != -1)
            {
                Console.WriteLine(Player);
            }
            else
            {
                Console.WriteLine(-1);
            }

            int Max_Number = 0;

            int Lenght = myInts_2.Count;


            while (myInts_2.Count != 0)
            {

                int temp_max = myInts_2.Max();
                Max_Number += temp_max;
                int IndextoRemove = Array.IndexOf(myInts_2.ToArray(), temp_max);

                myInts_2.RemoveAt(IndextoRemove);

                if (myInts_2.Count > 0)
                {
                    for (int x = 0; x < Friends - 1; x++)
                    {
                        if (myInts_2.Count > 0)
                        {
                            temp_max = myInts_2.Max();
                            IndextoRemove = Array.IndexOf(myInts_2.ToArray(), temp_max);
                            myInts_2.RemoveAt(IndextoRemove);
                        }

                    }
                }


            }

            Console.WriteLine(Max_Number);

          
            int[] input = Array.ConvertAll(a, int.Parse);


            int G1 = input[0];int S1 = input[1];int B1 = input[2];
            int G2 = input[3];int S2 = input[4];int B2 = input[5];
            int steps = 0;string way = "";


           if (G2 > G1)
           {
               while ( G1 < G2)
             {
                G1++;
                S1 -= 11;
                steps++;
                   
            }

        }



            if (S2 > S1)
            {
                while (S2 > S1)
                {
                    if (G1 > G2)
                    {
                        G1--;
                        S1 += 9;
                        steps++;
                    }
                    else
                    {
                        B1 -= 11;
                        S1++;
                        steps++;

                    }

                }


            }

       
            if (B1 < B2)
            {

                while (B1 < B2)
                {

                    if ( (G1== G2) && (S1 == S2))
                    {
                        break;
                    }                    


                    if (S1 > S2)
                    {
                        S1--;
                        B1 += 9;
                        steps++;
                    }

                    else
                    {
                        if (G1 > G2)
                        {
                            G1--;
                            S1 += 9;
                            steps++;

                        }
                    }
                 
                }

            }

            if ((G1 >= G2) && (B1 >= B2) && (S1 >= S2))
            {

                Console.WriteLine(steps);

            }
            else
            {
                Console.WriteLine(-1);
            }
            
            // End Task 3 


        }
    }
}
