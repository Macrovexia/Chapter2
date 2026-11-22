using System;

namespace CoinFlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the Random class to simulate a coin flip with an if statement
            var random = new Random();
            var randomFlip = random.Next(100);

            if (randomFlip <= 50)
            {
                Console.WriteLine($"Tails - {randomFlip}");
            }
            else
            {
                Console.WriteLine($"Heads - {randomFlip}");
            }

            // Using the Random class to simulate a coin flip with ternary operator
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");

            Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
        }
    }
}
