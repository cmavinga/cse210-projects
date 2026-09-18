//if the user chooses a number (1 to 5) to the prompt: 
// "What would you like to do? " all is well, but if he 
// writes something like "Load" (from the menu), the prompt 
// just comes back "What would you like to do?. 
// SO I INDICATED THE USER SHOULD CHOOSE FROM 1 TO 5
//ALSO I have added a message (Thank and Goodbye) if the user chooses 5.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices (1 to 5):");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do (Please select from 1 t0 5)? ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = 0;
            }

            if (choice == 1)
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                journal.AddEntry(new Entry(prompt, response));
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
            }
        }
    }
}