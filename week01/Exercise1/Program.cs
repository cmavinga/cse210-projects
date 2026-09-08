using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");


        // Grade Percentage

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);

        string letter = "";
        String sign = "";
        int lastDigit = percentage % 10;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter} {sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up and put more efforts next term.");
        }


        // Guess the magic number

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

        // C# Programming Exercise 4: Lists and Generics

        List<int> numbers;
        int number = -1;

        while (number != 0) ;
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number != 0)
        {
            numbers.Add(number);
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }


        Console.WriteLine($"The sum is: {sum}");


        int count = Console.WriteLine(numbers.Count);
        int average = sum / count;

        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        // C# Programming Exercise 5: Functions

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }

}



