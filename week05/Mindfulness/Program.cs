// I added invalid choice possibility (Lines 23 - 26), feedback the user immediately sees in case he types something other than "1", "2", "3", or "4".

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please select a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ReflectionActivity().Run();
            else if (choice == "3") new ListingActivity().Run();
            else if (choice == "4")
            {
                Console.WriteLine("Thank you, see you next time!");
            }
            else
            {
                Console.WriteLine("This is an invalid choice. Please select from 1 to 4!");
            }
        }
    }
}