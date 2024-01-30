using System;

namespace LogicalOperators
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Logical Operators
            Console.WriteLine("What's the temperature outsie (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It is warm outside");
            } 
            else if (temp <= -50 || temp >= 50) {
                Console.WriteLine("Do not go outside!");
            }


            Console.ReadKey();
        }
    }
}