using System;
//landscape size width and height = 1080px X 680px
//Portrait size width and height = 1080px X 1350px
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speed Limit ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Speed OF the Car =");
            var Speed_of_car = Convert.ToInt32(Console.ReadLine());

            if (Speed_of_car < speedLimit)
                Console.WriteLine("OK");
            else
            {
                const int Demeritpoints = 5;
                var demerit = (Speed_of_car - speedLimit) / Demeritpoints;
                if (demerit > 12)
                    Console.WriteLine("License Suspended");
                else
                {
                    Console.WriteLine("Demerit Points  " + demerit);
                }

            }
        }

    }
}
