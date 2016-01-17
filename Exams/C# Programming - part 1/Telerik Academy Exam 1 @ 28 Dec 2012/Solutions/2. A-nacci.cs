namespace DiamondTrolls
{
    using System;

    public class Diamonds
    {
        public static void Main()
        {


            string one = Console.ReadLine();
            string two = Console.ReadLine();


            int one1 = Convert.ToChar(one) - 64;
            int two2 = Convert.ToChar(two) - 64;
            int loop = int.Parse(Console.ReadLine());


            int temp1;

            int whitespace = 1;



            Console.WriteLine(one);


            if (loop > 1)
            {

                temp1 = one1 + two2;

                if (temp1 > 26)
                {

                    temp1 = temp1 % 26;
                }

                Console.Write(two); Console.Write((char)(64 + temp1));
                one1 = two2;
                two2 = temp1;

            }




            Console.WriteLine();
            for (int i = 0; i < loop - 2; i++)
            {


                temp1 = one1 + two2;

                if (temp1 > 26)
                {

                    temp1 = temp1 % 26;
                }

                Console.Write((char)(64 + temp1)); Console.Write(new string(' ', whitespace));

                one1 = two2;
                two2 = temp1;

                temp1 = one1 + two2;

                if (temp1 > 26)
                {

                    temp1 = temp1 % 26;
                }
                Console.Write((char)(64 + temp1));

                one1 = two2;
                two2 = temp1;
                whitespace++;
                Console.WriteLine();
            }








        }
    }
}
