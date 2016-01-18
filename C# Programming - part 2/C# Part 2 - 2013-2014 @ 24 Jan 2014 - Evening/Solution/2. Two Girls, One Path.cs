using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace VariableLengthCoding
{
   
    class VariableLengthCoding
    {
       
        static void Main()
        {


          string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

  

        

            BigInteger IndexMolly = 0;
            BigInteger IndexDolly = input.Length - 1;

            BigInteger SumMolly = 0;
            BigInteger SumDolly = 0;
            BigInteger BeingOnTheSameCell = 0;

            while(true)
            {

                 BigInteger FlowersMolly = BigInteger.Parse(input[(int)IndexMolly]);
                BigInteger FlowersDolly = BigInteger.Parse(input[(int)IndexDolly]);

                if (FlowersDolly != 0 && FlowersMolly != 0)
                {
                    if (IndexMolly != IndexDolly)
                    {
                        SumMolly += FlowersMolly;
                        SumDolly += FlowersDolly;

                        input[(int)IndexMolly] = "0";
                        input[(int)IndexDolly] = "0";

                    }
                    if (IndexMolly == IndexDolly)
                    {
                        BeingOnTheSameCell = int.Parse(input[(int)IndexDolly]);



                         if (FlowersDolly  % 2 == 0  )
                         {

                             SumMolly += (FlowersDolly + FlowersMolly) / 2;
                             SumDolly += (FlowersDolly + FlowersMolly) / 2;

                             input[(int)IndexMolly] = "0";
                            

                         }
                         else if (FlowersDolly % 2 == 1 )
                         {
                             BigInteger number = BigInteger.Parse(input[(int)IndexDolly]);
                             number--;
                             input[(int)IndexDolly] = number.ToString();

                             SumMolly += number / 2;
                             SumDolly += number / 2;
                             input[(int)IndexDolly] = "1";

                         }


                    }

                }
                if (FlowersDolly == 0 || FlowersMolly == 0)
                {
                    if (FlowersMolly != 0)
                    {
                        SumMolly += FlowersMolly;
                    }
                    if (FlowersDolly != 0)
                    {
                       SumDolly += FlowersDolly;
                    }

                    if (FlowersMolly == 0)
                    {
                        break;
                    }

                    if (FlowersDolly == 0)
                    {
                        break;
                    
                    }


                }

         
                if (FlowersMolly+IndexMolly > input.Length-1)
                {
                    if (BeingOnTheSameCell != 0)
                    {
                        FlowersMolly = BeingOnTheSameCell;
                
                    }
                    IndexMolly = (FlowersMolly+IndexMolly) % input.Length;


                }
                else
                {
                    if (BeingOnTheSameCell != 0)
                    {
                        FlowersMolly = BeingOnTheSameCell;
                 
                    }
                    IndexMolly = IndexMolly+ FlowersMolly;

                }


                if (IndexDolly - FlowersDolly  < 0)
                {
                    BigInteger TempValue = 0;
                    if (BeingOnTheSameCell != 0)
                    {
                        FlowersDolly = BeingOnTheSameCell;
                 
                    }
            
                    if (FlowersDolly < input.Length)
                    {
                        IndexDolly = input.Length - ((IndexDolly - (FlowersDolly)) * -1);
                    }

                    else if (FlowersDolly > input.Length-1)
                    {
                        TempValue = FlowersDolly;
                        TempValue %= input.Length;
                        IndexDolly = IndexDolly - TempValue;
                    }
                    
                }
                else
                {
                    if (BeingOnTheSameCell != 0)
                    {
                        FlowersDolly = BeingOnTheSameCell;
          
                    }
          
                    IndexDolly = IndexDolly - FlowersDolly;
                }

                if (BeingOnTheSameCell > 0)
                {

                    BeingOnTheSameCell = 0;

                }
  

            }

            if (input[(int)IndexMolly] == "0" && input[(int)IndexDolly] == "0")
            {

                Console.WriteLine("Draw");


            }
            else if (input[(int)IndexMolly] == "0")
            {
                Console.WriteLine("Dolly");

            }
            else if (input[(int)IndexDolly] == "0")
            {

                Console.WriteLine("Molly");

            }

            Console.Write(SumMolly); Console.Write(' ');
            Console.Write(SumDolly);



        }
    }
}