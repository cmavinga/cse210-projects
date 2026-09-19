// I added motivational messages (line 30) while memorizing the scripture.
// and an encouragement at the end (line 37)

using System;
using ScriptureMemorizer;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);

            if (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Well done, keep going!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Good job!");
                break;
            }
        }
    }
}
