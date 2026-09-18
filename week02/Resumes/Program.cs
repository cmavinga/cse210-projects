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
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Data Analyst";
        job2._startYear = 2020;
        job2._endYear = 2023;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        //job1.Display();
        //job2.Display();

        // I have to create a Resume Object
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // I add jobs to myResume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // I verify the  access to the first job
        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        // I display my full Resume
        myResume.Display();

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
            Console.Write("What would you like to do? ");

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