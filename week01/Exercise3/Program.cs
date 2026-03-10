using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            Console.Write("what is your guess? ");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the magic number!");
            }
        }
        
    }
}