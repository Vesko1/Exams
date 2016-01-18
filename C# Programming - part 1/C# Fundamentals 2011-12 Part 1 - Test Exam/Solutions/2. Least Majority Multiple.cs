using System;


namespace C_Sharp_1
{
    class Program
    {
        static void Main()
        {




            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int number = 1;
            int common = 0;

            while(true)
                {

                    if (number % a == 0)
                    {
                        common++;
                    }

                    if (number % b == 0)
                    {
                        common++;
                    }

                    if (number % c == 0)
                    {
                        common++;
                    }

                    if (number % d == 0)
                    {
                        common++;
                    }

                    if (number % e == 0)
                    {
                        common++;
                    }

                    if (common >= 3)
                    {

                        break;
                    }
                    else
                    {
                        common = 0;
                    }

                    number++;
                }

            Console.WriteLine(number);

        }
    }
}
