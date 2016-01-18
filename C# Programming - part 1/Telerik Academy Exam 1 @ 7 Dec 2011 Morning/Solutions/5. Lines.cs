using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;




namespace C_Sharp_1
{
    class Program
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

            int linelength = 0;

            int NumTimes = 1;
            int maxlength = 0;

            int currentBit = 0;


            for (int i = 0; i < 8; i++)
            {
                int lastbit = 1;

                for (int p = 0; p < 8; p++)
                {

                    currentBit = grid[p, i];

                    if (currentBit == 1 && lastbit == 1) { linelength++; }
                    if (currentBit == 1 && lastbit == 0) { linelength++; }
                    if (currentBit == 0 && lastbit == 1) // indikacia 4e svarshva temp liniqta
                    {


                        if (linelength == maxlength && linelength > 0)
                        {
                            NumTimes++;
                        }

                        if (linelength > maxlength && linelength > 0)
                        {

                            maxlength = linelength;
                            NumTimes = 1;

                        }
                        linelength = 0;
                    }
                    if (p == 7)
                    {
                        if (linelength == maxlength && linelength > 0)
                        {
                            NumTimes++;
                        }

                        if (linelength > maxlength && linelength > 0)
                        {

                            maxlength = linelength;
                        }
                        linelength = 0;
                    }

                    lastbit = currentBit;

                }

            }





            int linelength1 = 0;

            int NumTimes1 = 1;
            int maxlength1 = 0;

            int currentBit1 = 0;


            for (int i = 0; i < 8; i++)
            {
                int lastbit1 = 1;

                for (int p = 0; p < 8; p++)
                {

                    currentBit1 = grid[i, p];

                    if (currentBit1 == 1 && lastbit1 == 1) { linelength1++; }
                    if (currentBit1 == 1 && lastbit1 == 0) { linelength1++; }
                    if (currentBit1 == 0 && lastbit1 == 1) // indikacia 4e svarshva temp liniqta
                    {


                        if (linelength1 == maxlength1 && linelength1 > 0)
                        {
                            NumTimes1++;
                        }

                        if (linelength1 > maxlength1 && linelength1 > 0)
                        {

                            maxlength1 = linelength1;
                            NumTimes1 = 1;

                        }
                        linelength1 = 0;
                    }
                    if (p == 7)
                    {
                        if (linelength1 == maxlength1 && linelength1 > 0)
                        {
                            NumTimes1++;
                        }

                        if (linelength1 > maxlength1 && linelength1 > 0)
                        {

                            maxlength1 = linelength1;
                        }
                        linelength1 = 0;
                    }
                       
                    lastbit1 = currentBit1;

                }

            }


            if (maxlength == 1 && maxlength1 == 1)
            {
                Console.WriteLine(maxlength);
                Console.WriteLine(NumTimes);
            }
            else if (maxlength == maxlength1)
            {

                Console.WriteLine(maxlength1); 
                Console.WriteLine(NumTimes1+NumTimes);
            }

            else if (maxlength > maxlength1)
            {
                Console.WriteLine(maxlength);
                Console.WriteLine(NumTimes);

            }

            else
            {
                Console.WriteLine(maxlength1);
                Console.WriteLine(NumTimes1);
            
            }

 
            }
    }
}
