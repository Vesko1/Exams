using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
    
    
    
namespace C_Sharp_1
{
    class Program
    {
        static void Main()
        {
    
    
          
           StringBuilder string_number = new StringBuilder();
  
            string number1 = Console.ReadLine();
  
            foreach (var item in number1)
            {
                if ((int)item > 47 && (int)item < 58)
                {
  
                    string_number.Append(item);
                }
            }
    
             BigInteger number = BigInteger.Parse(string_number.ToString());
 
 
 
           
            BigInteger sum = 0;
 
            while (true)
            {
                sum = sum + (number % 10);
                number = (number / 10);
 
 
 
                if (number <= 0 && sum <= 9)
                    break;
 
                if (number <= 0 && sum > 9)
                {
 
                    number = sum;
                    sum = 0;
                }
 
 
            }
 
            Console.WriteLine(sum);
    
    
    
    
    
        }
    }
}