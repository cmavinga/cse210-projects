using System;

class Program
{
    static void Main(string[] args)
    {
        string userAnswer = "Yes";
        while (userAnswer == "Yes")
        {
            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());

            int userNumber = -1;
            int guessCount = 0;

            while (userNumber != magicNumber)
            {
                Console.Write("What is the magic number? ");
                int magicNumber = int.Parse(Console.ReadLine());
                guessCount++;

                if (userNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed the number!");
                    Console.WriteLine($"After {guessCount} guess!")
                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
        }
        Console.WriteLine("Thanks for playing!");
    }
}