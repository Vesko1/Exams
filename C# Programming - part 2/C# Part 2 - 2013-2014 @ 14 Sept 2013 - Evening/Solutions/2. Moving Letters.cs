using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
//using System.Threading.Tasks;

namespace TryAndDelete2
{
    class Program
    {
        // abc abcd ab

        static void Main(string[] args)
        
        {
//
           StringBuilder chars = new StringBuilder();


           List<string> list1 = new List<string>(Console.ReadLine().Split());
           
 
          int MaxLenght = 0;


          for (int i = 0; i < list1.Count; i++)
          {
              
              if (list1[i].Length > MaxLenght)
              {
                  MaxLenght = list1[i].Length;

              }

          }



          for (int i = 0; i < MaxLenght; i++)
          {


              for (int q = 0; q < list1.Count; q++)
              {
                  

                  if ( list1[q].Length -1 - i >= 0  )
                  {
                      char check = list1[q][list1[q].Length-1-i];

                      chars.Append(check); 


                  }
              }


          }


          int steps = 0;

          for (int i = 0; i < chars.Length; i++)
          {
              int leng = chars.Length;
              char moving = chars[i];

              steps = (int)Char.ToLower(chars[i]) - 96;


              chars.Remove(i, 1);

              int insert = (steps % leng + i);


              if (insert == leng)
              {

                  insert = 0;
              }
              if (insert > leng)
              {
                  insert = insert % leng;

              }

              chars.Insert(insert, moving);
             
          }


          Console.WriteLine(chars);


        }
    }
}
