using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal         journal = new Journal();
        int             menuUserInput = 0;
        PromptGenerator p = new PromptGenerator();

        List<string>    menu = new List<string>
        {
            "Please select one of the following choices:",
            "1. Write",
            "2. Display",
            "3. Save",
            "4. Load",
            "5. Quit",
            "What would you like to do?"
        };
        
        


    while (menuUserInput != 5)
    {
        foreach(string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }
        menuUserInput = int.Parse(Console.ReadLine());

        if (menuUserInput == 1)
            {
                string prompt = p.GetRandomPrompt();
                Console.WriteLine(prompt);
                string res = Console.ReadLine();
                Entry entry = new Entry(prompt,res);
                journal.CreateJournalEntry(entry);
            }
            else if (menuUserInput == 2)
            {
                journal.DisplayJournalEntries();

            }
            else if (menuUserInput == 3)
            {
                Console.WriteLine("Enter file name.");
                journal.SaveToCSV(Console.ReadLine());
            }
            else if (menuUserInput == 4)
            {
                Console.WriteLine("Enter file name.");
                journal = journal.LoadFromCSV(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Thank you for using the Journal App!");
            }
    }
    }
}