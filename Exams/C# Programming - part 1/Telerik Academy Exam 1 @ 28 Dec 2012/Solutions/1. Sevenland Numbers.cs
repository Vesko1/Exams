namespace DiamondTrolls
{
    using System;

    public class Diamonds
    {
        public static void Main()
        {



            string input = Console.ReadLine();

            int length = input.Length;

            int number = int.Parse(input);

            if (length == 1)
            {

                if ((number % 10) < 6)
                {

                    Console.WriteLine(number + 1);

                }
                else
                {
                    Console.WriteLine(10);


                }


            }

            if (length == 2)
            {

                int f2 = number / 10;

                if ((number % 10) < 6)
                {

                    Console.WriteLine(number + 1);

                }

                else
                {

                    Console.WriteLine(++f2 * 10);

                }




            }


            if (length == 3)
            {
                int f3 = number / 10;


                if ((number % 10) < 6)
                {

                    Console.WriteLine(number + 1);

                }

                else if ((f3 % 10) < 6)
                {

                    Console.WriteLine((f3 + 1) * 10);

                }

                else if ((f3 % 10) == 6)
                {
                    int f33 = f3 / 10;
                    Console.WriteLine(++f33 * 100);

                }


            }

        }
    }
}
