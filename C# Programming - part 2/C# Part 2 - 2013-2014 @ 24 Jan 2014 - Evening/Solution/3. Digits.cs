using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace VariableLengthCoding
{
   
    class VariableLengthCoding
    {
        static int n;
        static int[,] matrix;
    
     

        static bool Edno(int a, int b)
        {

           
            if (matrix[a, b] == 1 &&
                            matrix[a, b] == 1 &&
                            matrix[a+1, b - 1] == 1 &&
                            matrix[a +2, b - 2] == 1 &&
                            matrix[a + 1, b] == 1 &&
                            matrix[a + 2, b] == 1 &&
                            matrix[a + 3, b] == 1 &&
                            matrix[a + 4, b] == 1 )
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        static bool Dve(int a, int b)
        {

         
            if (matrix[a, b] == 2 &&
                            matrix[a + 1, b - 1] == 2 &&
                           matrix[a + 1, b + 1] == 2 &&
                           matrix[a + 2, b + 1] == 2 &&
                           matrix[a + 3, b] == 2 &&
                           matrix[a + 4, b] == 2 &&
                           matrix[a + 4, b - 1] == 2 &&
                           matrix[a + 4, b + 1] == 2)
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        static bool Tri(int a, int b)
        {
            
            if (matrix[a, b] == 3 &&
                matrix[a, b - 1] == 3 &&
                matrix[a, b - 2] == 3 &&
                matrix[a + 1, b] == 3 &&
                matrix[a + 2, b ] == 3 &&
                matrix[a +2, b - 1] == 3 &&
                matrix[a +3, b] == 3 &&
                matrix[a +4, b] == 3 &&
                matrix[a +4, b-1] == 3 &&
                matrix[a +4, b-2] == 3 )
         
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        static bool Chetiri(int a, int b)
        {

        
            if (matrix[a, b] == 4 &&
                            matrix[a+1, b] == 4 &&
                            matrix[a+2, b] == 4 &&
                            matrix[a+3, b] == 4 &&
                            matrix[a+4, b] == 4 &&
                            matrix[a +2, b - 1] == 4 &&
                            matrix[a +2, b - 2] == 4 &&
                            matrix[a +1, b-2] == 4 &&
                            matrix[a, b-2] == 4)
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        static bool Pet(int a, int b)
        {
          
            if (            matrix[a, b - 1] == 5 &&
                            matrix[a, b - 2] == 5 &&
                            matrix[a + 1, b - 2] == 5 &&
                            matrix[a + 2, b - 2] == 5 &&
                            matrix[a +2, b - 1] == 5 &&
                            matrix[a +2, b] == 5 &&
                            matrix[a +3, b] == 5 &&
                            matrix[a +4, b] == 5 &&
                            matrix[a +4, b-1] == 5 &&
                            matrix[a + 4, b-2] == 5)
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        static bool Shest(int a, int b)
        {
           
            if (matrix[a, b] == 6 &&
                            matrix[a, b - 1] == 6 &&
                            matrix[a, b - 2] == 6 &&
                            matrix[a +1, b - 2] == 6 &&
                            matrix[a + 2, b - 2] == 6 &&
                            matrix[a + 3, b - 2] == 6 &&
                            matrix[a + 4, b - 2] == 6 &&
                            matrix[a +2, b-1] == 6 &&
                            matrix[a + 2, b] == 6 &&
                            matrix[a + 3, b] == 6 &&
                            matrix[a + 4, b] == 6 &&
                            matrix[a + 4, b - 1] == 6)
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        static bool Sedem(int a, int b)
        {


            if (matrix[a, b] == 7 &&
                            matrix[a, b - 1] == 7 &&
                            matrix[a, b - 2] == 7 &&
                            matrix[a + 1, b] == 7 &&
                            matrix[a + 2, b - 1] == 7 &&
                            matrix[a + 3, b - 1] == 7 &&
                            matrix[a + 4, b - 1] == 7)
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        static bool Osem(int a, int b)
        {
       
            if (matrix[a, b] == 8 &&
                            matrix[a, b - 1] == 8 &&
                            matrix[a, b - 2] == 8 &&
                            matrix[a + 1, b] == 8 &&
                            matrix[a +2, b - 1] == 8 &&
                            matrix[a +1, b - 2] == 8 &&
                            matrix[a +3, b] == 8 &&
                            matrix[a +4, b] == 8 &&
                            matrix[a +3, b-2] == 8 &&
                            matrix[a +4, b-2] == 8 &&
                            matrix[a + 4, b-1] == 8)
            {

                return true;
            }

            else
            {
                return false;
            }
        }

        static bool Devet(int a, int b)
        {
     
            if (matrix[a, b] == 9 &&
                            matrix[a, b - 1] == 9 &&
                            matrix[a, b - 2] == 9 &&
                            matrix[a + 1, b] == 9 &&
                            matrix[a +1, b - 2] == 9 &&
                            matrix[a + 2, b] == 9 &&
                            matrix[a +2, b - 1] == 9 &&

                            matrix[a +3, b] == 9 &&
                            matrix[a +4, b] == 9 &&
                            matrix[a +4, b-1] == 9 &&
                            matrix[a + 4, b-2] == 9)
            {

                return true;
            }

            else
            {
                return false;
            }
        }


        static void Main()
        {

            n = int.Parse(Console.ReadLine());
            int sum = 0;
            matrix = new int[n, n];



            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] Input = Console.ReadLine().Split();

                for (int a = 0; a < n; a++)
                {

                    matrix[i, a] = Convert.ToInt32(Input[a]);

                }

            }


            for (int i = 0; i < n-4; i++)
            {

                for (int q = 2; q < n; q++)
                {
                                      
                        if (matrix[i, q-1] == 2)
                        {
                            if (Dve(i, q-1))
                            {
                              sum += 2;
                                
                            }

                        }

                                   
                        if (matrix[i, q] == 1)
                        {

                            if (Edno(i, q))
                            {
                        
                                sum += 1;
                                continue;
                            }

                        }
                   
                        if (matrix[i, q] == 3)
                        {
                            if (Tri(i, q))
                            {
                               sum += 3;
                                continue;
                            }

                        }

                        if (matrix[i, q] == 4)
                        {
                            if (Chetiri(i, q))
                            {
                               sum += 4;
                                continue;
                            }

                        }
                   

                        if (matrix[i, q] == 5)
                        {
                            if (Pet(i, q))
                            {
                               
                                sum += 5;
                                continue;
                            }

                        }


                        if (matrix[i, q] == 6)
                        {
                            if (Shest(i, q))
                            {
                                                     
                                sum += 6;
                                continue;
                            }

                        }
                  
                 
                        if (matrix[i, q] == 7)
                        {
                            if (Sedem(i, q))
                            {
                            
                                sum += 7;
                                continue;
                            }

                        }


                        if (matrix[i, q] == 8)
                        {
                            if (Osem(i, q))
                            {
                            
                                sum += 8;
                                continue;
                            }

                        }
                  

                        if (matrix[i, q] == 9)
                        {
                            if (Devet(i, q))
                            {
                              
                          
                                sum += 9;
                                continue;
                            }

                        }
                
                }


            }


            Console.WriteLine(sum);






        }
    }
}