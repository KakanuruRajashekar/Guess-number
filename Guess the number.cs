using System;

namespace ProgChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumber = new Random().Next(50);
            bool keepGoing = true;

            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 50.");
            Console.WriteLine("Enter your guess, or -1 to give up.");
            int guessNum = 0;
            int guessCount = 0;
            do {
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();
                bool result = Int32.TryParse(theGuess, out guessNum);
                if (!result) {
                    Console.WriteLine("Hooo shut!, that doesn't look like a number. Try again.");
                }
                else {
                    if (guessNum == -1) {
                        Console.WriteLine($"Oh well. I was thinking of {theNumber}");
                        keepGoing = false;
                    }
                    else {
                        guessCount++;
                        if (guessNum == theNumber) {
                            Console.WriteLine($"You got it in {guessCount} guesses!!");
                            keepGoing = false;
                        }
                        else {
                        
                            Console.WriteLine("Nope, {0} than that.", guessNum < theNumber ? "higher" : "lower");
                        }
                    }
                }
            } while(keepGoing);
        }
    }
}