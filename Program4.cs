//Program to count divisible by 3 from 1 to 100
using System;
namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
        {
            var count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisble from 1 to 100",count);
        }
            
        

    }
}
