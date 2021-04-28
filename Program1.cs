using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers between 1 to 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine(" valid");
            }
            else
                Console.WriteLine("Invalid");
        }
    }
}
