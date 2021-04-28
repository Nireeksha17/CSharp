//Random class
using System;
namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);
            Console.WriteLine("Secret Number is:"+number);

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Guess the Number");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You Won YEah!!!!!");
                    return;
                }

            }
            Console.WriteLine("You LOST Loser");
        }
            
        

    }
}
