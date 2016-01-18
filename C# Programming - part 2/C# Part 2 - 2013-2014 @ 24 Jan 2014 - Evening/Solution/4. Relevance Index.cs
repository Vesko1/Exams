using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Linq;

namespace VariableLengthCoding
{

    class VariableLengthCoding
    {
       

        static void Main()
        {

            string word = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            string[] text = new string[n];

            int[] occurence = new int[n];

            for (int i = 0; i < n; i++)
            {

                text[i] = Console.ReadLine();
 
            }

            for (int i = 0; i < n; i++)
            {
               string[] Temp = text[i].Split(new char[] { ' ', ',', '.', ';',')','(', '-', '!', '?', }, StringSplitOptions.RemoveEmptyEntries);
       
                for (int q = 0; q < Temp.Length; q++)
               {
                   if (Temp[q].ToLower() == word.ToLower())
                   {
                       occurence[i]++;
                     Temp[q] = Temp[q].ToUpper();
                   }
                   

               }
               text[i] = string.Join(" ", Temp);

             }
       
            for (int i = 0; i < n; i++)
            {
                int Max = occurence.Max();
                int indexof = Array.IndexOf(occurence, Max);

                Console.WriteLine(text[indexof]);
                occurence[indexof] = -1;

            }


        }
    }
}