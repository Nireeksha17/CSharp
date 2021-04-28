//Program to count divisible by 3 from 1 to 100
using System;
namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("enter a number (or 'ok' to exit): ");

                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);

            }
            Console.WriteLine("Sum of all numbers is " + sum);

        }



    }
}
