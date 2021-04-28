//Factorial Of a Number
using System;
namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            var nummber = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (int i = 1; i < nummber; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", nummber, factorial);
        }



    }
}
