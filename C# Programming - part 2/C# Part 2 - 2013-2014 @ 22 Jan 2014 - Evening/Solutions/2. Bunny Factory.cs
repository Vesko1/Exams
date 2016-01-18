using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace EncodeAndEncrypt
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var list = new List<BigInteger>();
            var sublist = new List<BigInteger>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                list.Add(BigInteger.Parse(input));
            }

            int cycle = 1;
            BigInteger sum = 0;
            BigInteger product = 1;
            var SB = new StringBuilder();


            while(true)
            {
                if (list.Count < cycle)
                {
                    break;
                }
               sublist = list.GetRange(0, cycle);
               product = sublist.Aggregate((a, b) => b * a);
             
               BigInteger start = sublist.Count;
     
               sum = 0;
               foreach (var item in sublist)
               {
                   sum += item;
         
               }
           

               if (sum <= list.Count - cycle)
               {
          
                   int delimiter = sublist.Count;
                   int visited = 1;
                   int lastelement = 0;
                   while(true)
                   {
                       if (sum <= list.Count - delimiter && visited == 1) 
                       {
                           sublist = list.GetRange((int)start, (int)sum);

                           sum = 0;
                 
                           start += sublist.Count;
                           product = sublist.Aggregate((a, b) => b * a);
                     
                           foreach (var item in sublist)
                           {
                               sum += item;
                       
                           }
                           
                          
                           delimiter += sublist.Count;
                           visited = 0;

                       }
                       else
                       {
                    
                           sublist = list.GetRange(delimiter, list.Count - delimiter); 
                           SB.Clear();

                           SB.Append(sum);
                           SB.Append(product);
                           SB.Append(string.Join("", sublist.ToArray()));

                           list.Clear();
                  
                           for (int d = 0; d < SB.Length; d++)
                           {

                               if (SB[d] == '1' || SB[d] == '0')
                               {
                                   continue;

                               }
                               else
                               {
                                   list.Add(BigInteger.Parse((SB[d].ToString())));

                               }

                           }


                           break;
                          
                       }
                   }

                  
               }
                else
               {
                                     break;
               }
                
               cycle++;
            }
            Console.WriteLine(string.Join(" ", list.ToArray()));


        }
    }
}
