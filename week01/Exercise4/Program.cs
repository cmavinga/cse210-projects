using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}