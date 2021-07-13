using System;

namespace Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick heads or tails.");
            string answer = Console.ReadLine();

            int final;
            if (answer.ToLower() == "heads")
            {
                final = 1;
            }
            else
            {
                final = 2;
            }

            Random rand = new Random();

            int flip = rand.Next(1, 3);
            

            if (flip == 1)
            {
                Console.WriteLine("The coin landed on heads!");
            }
            else
            {
                Console.WriteLine("The coin landed on tails!");
            }

            if (final == flip)
            {
                Console.WriteLine("You guessed the correct flip!");
            }
            else
            {
                Console.WriteLine("You got it wrong, try again!");
            }

            const string developer = "Developer: Jeffrey Nightengale";

            Console.WriteLine(developer);
        }
    }
}
