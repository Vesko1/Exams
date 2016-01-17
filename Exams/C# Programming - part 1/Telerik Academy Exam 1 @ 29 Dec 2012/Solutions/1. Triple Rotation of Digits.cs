using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class BullsAndCows
{
    static void Main()
    {


        string digit_string = Console.ReadLine();

        StringBuilder temp = new StringBuilder(digit_string);



        for (int i = 0; i < 3; i++)
        {

            temp.Insert(0, temp[temp.Length - 1]);
            temp.Length--;

            int x = Math.Abs(int.Parse(temp.ToString()));

            temp.Clear();
            temp.Append(x);

            }
           Console.WriteLine(temp);

    }
}