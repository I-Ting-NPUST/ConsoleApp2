using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { 
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            double money=0;
            money = meal_cost+tip_percent + tax_percent;
            Console.WriteLine("meal_cost 100 元");
            Console.WriteLine("tip_percent 15元");
            Console.WriteLine("tax_percent 8元");

            Console.WriteLine("total "+money+"元");
        }
    }
}
