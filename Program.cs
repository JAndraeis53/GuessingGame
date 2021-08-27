using System;
using System.Collections.Generic;

namespace GussingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("difficulty level? 1 - easy, 2 - medium, 3 - hard");
            var difficulty = int.Parse(Console.ReadLine());

            int secretNumber = new Random().Next(1, 101); 

            var difficultiesTries = new int[]{ 8, 6, 4 };

            for (int i = difficultiesTries[difficulty - 1]; i > 0; i--)
            {
                Console.WriteLine("Dare to guess my secret number");
                Console.Write($"Your Guess (Guesses left: {i}): ");
                var response = int.Parse(Console.ReadLine());


                if (secretNumber == response)
                {
                    Console.WriteLine("...Congratulations...");
                    break;
                }
                else if (secretNumber > response)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Too High");
                };
            }
        }
    }
};

// if (difficulty == 4)
// {
//     while (true)
//     {
//         Console.WriteLine("Guess the secret number!");
//         Console.Write("Your Guess (Guesses Left: INFINITE!): ");
//         var input = int.Parse;
//     }
// }