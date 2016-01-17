using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class BullsAndCows
{
    static void Main()
    {


        decimal tomato_price = decimal.Parse(Console.ReadLine()) * 0.5m;
        int tomato_area = int.Parse(Console.ReadLine());

        decimal cucumber_price = decimal.Parse(Console.ReadLine()) * 0.4m;
        int cucumber_area = int.Parse(Console.ReadLine());

        decimal potato_price = decimal.Parse(Console.ReadLine()) * 0.25m;
        int potato_area = int.Parse(Console.ReadLine());

        decimal carrot_price = decimal.Parse(Console.ReadLine()) * 0.6m;
        int carrot_area = int.Parse(Console.ReadLine());

        decimal cabbage_price = decimal.Parse(Console.ReadLine()) * 0.3m;
        int cabbage_area = int.Parse(Console.ReadLine());

        decimal beans_price = decimal.Parse(Console.ReadLine()) * 0.4m;
        int beans_area = 250 - (tomato_area + cucumber_area + potato_area + carrot_area + cabbage_area);



        decimal total_cost = tomato_price + cucumber_price + potato_price + carrot_price + cabbage_price + beans_price;




       

        if (beans_area > 0)
        {

            Console.WriteLine("Total costs: {0:F2}", total_cost);
            Console.WriteLine("Beans area: {0}", beans_area);



        }
        else if (beans_area < 0)
        {

            Console.WriteLine("Total costs: {0:F2}", total_cost);
            Console.WriteLine("Insufficient area");

        }
        else
        {

            Console.WriteLine("Total costs: {0:F2}", total_cost);
            Console.WriteLine("No area for beans");
        }


    }

}