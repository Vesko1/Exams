using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            StringBuilder coded = new StringBuilder();  

            string[] alist = new string[input];

            for (int i = 0; i < input; i++)
            {
                string x = Console.ReadLine();
                list.Add(x);
                alist[i] = x;

            }

            for (int i = 0; i < input; i++)
            {
                string word = list[i];

                int place = word.Length % (input + 1);

                list[i] = null;
                list.Insert(place, word);
                list.Remove(null);
                
            }

            int MaxLength = 0;


            for (int i = 0; i < alist.Length; i++)
            {

                if (alist[i].Length > MaxLength)
                {
                    MaxLength = alist[i].Length;
                }


            }



            for (int i = 0; i < MaxLength; i++)
            {
                for (int q = 0; q < list.Count; q++)
                {
                    if (i < list[q].Length)
                    {
                    coded.Append(list[q][i]);
                    }
                }


                
            }

            Console.WriteLine(coded);
         

        }
    }
}