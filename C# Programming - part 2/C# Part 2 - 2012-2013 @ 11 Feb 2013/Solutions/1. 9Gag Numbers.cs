using System;
using System.Linq;
using System.Text;


class Bittris
{

    static void Main()
    {


        string input = Console.ReadLine();




        StringBuilder signs = new StringBuilder();

        StringBuilder numbers = new StringBuilder();


        for (int i = 0; i < input.Length; i++)
        {


            if ((int)input[i] == 33 || (int)input[i] == 38 || (int)input[i] == 42 || (int)input[i] == 45)
            {
                signs.Append(input[i]);

                string checker = signs.ToString();

                if (checker == "-!")
                {
                    numbers.Append(0);
                    signs.Clear();
                }

                if (checker == "**")
                {
                    numbers.Append(1);
                    signs.Clear();
                }

                if (checker == "!!!")
                {
                    numbers.Append(2);
                    signs.Clear();
                }

                if (checker == "&&")
                {
                    numbers.Append(3);
                    signs.Clear();
                }

                if (checker == "&-")
                {
                    numbers.Append(4);
                    signs.Clear();
                }

                if (checker == "!-")
                {
                    numbers.Append(5);
                    signs.Clear();
                }

                if (checker == "*!!!")
                {
                    numbers.Append(6);
                    signs.Clear();
                }

                if (checker == "&*!")
                {
                    numbers.Append(7);
                    signs.Clear();
                }

                if (checker == "!!**!-")
                {
                    numbers.Append(8);
                    signs.Clear();
                }

            }

        }

        int length = numbers.ToString().Length;


        decimal result = 0m;


        decimal power = 1m;



        for (int i = length - 1; i > -1; i--)
        {

            result += int.Parse(numbers[i].ToString()) * power;

            power *= 9m;

        }


        Console.WriteLine(result);
    }





}
