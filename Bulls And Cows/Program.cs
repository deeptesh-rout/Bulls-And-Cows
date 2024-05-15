using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Bulls and Cows!");
        Console.WriteLine("Guess the 4-digit number.");

        
        Random random = new Random();
        int[] secretNumber = new int[4];
        for (int i = 0; i < 4; i++)
        {
            secretNumber[i] = random.Next(10);
        }

        int attempts = 0;

        while (true)
        {
            Console.Write("Enter your guess (4 digits): ");
            string input = Console.ReadLine();

            if (input.Length != 4 || !int.TryParse(input, out _))
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit number.");
                continue;
            }

            int[] guess = new int[4];
            for (int i = 0; i < 4; i++)
            {
                guess[i] = int.Parse(input[i].ToString());
            }

            attempts++;

            int bulls = 0;
            int cows = 0;

            // Count bulls and cows
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secretNumber[i])
                {
                    bulls++;
                }
                else if (Array.IndexOf(secretNumber, guess[i]) != -1)
                {
                    cows++;
                }
            }

            // Check if the guess is correct
            if (bulls == 4)
            {
                Console.WriteLine($"Congratulations! You guessed the number {string.Join("", secretNumber)} in {attempts} attempts.");
                break;
            }
            else
            {
                Console.WriteLine($"Bulls: {bulls}, Cows: {cows}");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.ReadLine(); // This line waits for the user to press Enter before closing the console window.
    }
}



















/*Bulls and Cows is a code-breaking game where one player, the "codemaker," selects a secret code, and the other player, the "codebreaker," tries to guess it. 
 * In the game, a "bull" represents a correct digit in the correct position, and a "cow" represents a correct digit in the wrong position.

In the provided code:

The program generates a random 4-digit number as the secret code (secretNumber).
The player is prompted to enter their guess, also a 4-digit number.
The program then compares each digit of the guess with the corresponding digit of the secret code to count the number of bulls and cows.
If a digit in the guess matches the corresponding digit in the secret code and is in the same position, it's counted as a bull. 
If it matches but is in a different position, it's counted as a cow.
The game continues until the player guesses the correct number (4 bulls).
After the game ends, the program waits for the user to press Enter before closing the console window.
The term "bulls and cows" comes from an older version of the game where players used words instead of numbers. "Bulls" referred to the letters that were correct 
and in the right position, and "cows" referred to correct letters that were in the wrong position.*/