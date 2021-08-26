using System;
using System.Collections.Generic;

namespace GussingGame
{
    class Program
    {
        static void Main(string[] args)
        {

// Display a message to the user asking them to guess the secret number.
            Console.WriteLine("Dare to guess my secret number");
// Display a prompt for the user's guess.
            Console.Write("Enter a number if you dare ");
// Take the user's guess as input and save it as a variable.
            string response = Console.ReadLine();
// Display the user's guess back to the screen.
            Console.WriteLine(response);

// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
            int secretNumber = 42; 
// No longer display the user's guess. They know what they guessed, right?
            int guess = int.Parse(response);
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
            if (secretNumber == guess)
            {
                Console.WriteLine("...Congratulations...");
            }
            else 
            {
                Console.WriteLine("FAILURE!");
            }

// Give the user four chances to guess the number.

// Continue to display the success or failure messages as in phase 2

        }
    }
}