using System;

class Program
{
    static void Main(string[] args)
    {
        int             menuUserInput = 0;
        List<string>    menu = new List<string>
        {
            "Please select one of the following choices:",
            "1. Start Breathing Activity",
            "2. Start Reflection Activity",
            "3. Start Listing Activity",
            "4. Quit",
            "Please select an activity?"
        };

    while (menuUserInput != 4)
    {
        foreach(string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }
        menuUserInput = Int32.Parse(Console.ReadLine());

        if (menuUserInput == 1)
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                breathing.GetActivityName();
                breathing.GetActivityDescription();
                int seconds = breathing.GetActivityTime();
                breathing.GetReady();
                breathing.Breathing(seconds);
                breathing.GetDone();
            }
            else if (menuUserInput == 2)
            {
                Console.Clear();
                ReflectionActivity reflecting = new ReflectionActivity("Reflecting", 0);
                reflecting.GetActivityName();
                reflecting.GetActivityDescription();
                int seconds = reflecting.GetActivityTime();
                reflecting.GetReady();
                reflecting.ShowPrompt(seconds);
                reflecting.GetDone();
            }
            else if (menuUserInput == 3)
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity("Listing", 0);
                listing.GetActivityName();
                listing.GetActivityDescription();
                int seconds = listing.GetActivityTime();
                listing.GetReady();
                listing.ReturnPrompt(seconds);
                listing.GetDone();
            }
            else
            {
                Console.WriteLine("Thanks for using the mindfulness App!");
            }
            //To show creativity this week I made each prompt and question random. 
            //I also stored the spinner and animation in their own class to clean up the code.
        
    }
    
    }
}