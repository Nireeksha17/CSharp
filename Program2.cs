using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
                Console.WriteLine("The MAximum  number is " + number1);
            else
                Console.WriteLine("The Maximum  number is" + number2);
        }
    }
}