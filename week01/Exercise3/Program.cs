using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);
        int guessNum = -1;
        int guessCount = 0;
        while (guessNum != magicNum)
        {
            Console.Write("What is your guess? ");
            guessNum = int.Parse(Console.ReadLine());
            if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            guessCount++;
        }
        Console.WriteLine($"Guesses taken: {guessCount}");
    }
}