using System;
using System.Text;
using System.Collections.Generic;

class Program
{

   
     static void Main()
    {

        
        string input = Console.ReadLine();

        ulong input_length = Convert.ToUInt64(input.Length);
        ulong input_long = ulong.Parse(input);

         ulong NineBased = 0;

        var Sb = new StringBuilder();

        if (input_long > 0)
        {
            while (input_long > 0)
            {

                Sb.Append(NineBased = input_long % 9);
                input_long /= 9;

            }
        }
         else
        {

            Sb.Append(0);
        }
        char[] inputarray = Sb.ToString().ToCharArray();
        Array.Reverse(inputarray);
        string output = new string(inputarray);

        Sb.Clear();

        for (int i = 0; i < output.Length; i++)
        {
            
            if (output[i] == '0')
            {
                Sb.Append("LON+");

            }
            if (output[i] == '1')
            {
                Sb.Append("VK-");

            }
            if (output[i] == '2')
            {
                Sb.Append("*ACAD");

            }
            if (output[i] == '3')
            {
                Sb.Append("^MIM");

            }
            if (output[i] == '4')
            {
                Sb.Append("ERIK|");

            }
            if (output[i] == '5')
            {
                Sb.Append("SEY&");

            }
            if (output[i] == '6')
            {
                Sb.Append("EMY>>");

            }
            if (output[i] == '7')
            {
                Sb.Append("/TEL");

            }

            if (output[i] == '8')
            {
                Sb.Append("<<DON");

            }


        }



       Console.WriteLine(Sb);

    }
}
