using System;
using System.Collections.Generic;
using System.Text;


namespace VariableLengthCoding
{
   
    class VariableLengthCoding
    {
       
        static void Main()
        {
            //     1256
            string input = Console.ReadLine();
           // string input = "hTmNTRAVLoBJEClPVKNQfffoBJECpNWE";

            StringBuilder number = new StringBuilder();
            int startindex = 0;
            int counter = 1;
            for (int i = 0; i < input.Length; i++)
            {

                string substring = input.Substring(startindex, counter);


                if (substring == "f")
                {
                    number.Append(0);
                    startindex = i+1;
                    counter = 0;

                }
                if (substring == "bIN")
                {
                    number.Append(1);
                    startindex = i + 1;
                    counter = 0;

                }
                if (substring == "oBJEC")
                {
                    number.Append(2);
                    startindex = i + 1;
                    counter = 0;

                }

                if (substring == "mNTRAVL")
                {
                    number.Append(3);
                    startindex = i + 1;
                    counter = 0;

                }

                if (substring == "lPVKNQ")
                {
                    number.Append(4);
                    startindex = i + 1;
                    counter = 0;

                }
                if (substring == "pNWE")
                {
                    number.Append(5);
                    startindex = i + 1;
                    counter = 0;

                }
                if (substring == "hT")
                {
                    number.Append(6);
                    startindex = i + 1;
                    counter = 0;

                }

                counter++;

            }
            long sum = 0;
            long power = 1;
            for (int i = number.ToString().Length-1; i > -1; i--)
            {
                int temp = int.Parse(number[i].ToString());
                sum += temp * power;
                power = power * 7;
            }


            Console.WriteLine(sum);
        }
    }
}