using System;
using System.Collections.Generic;

class MotivationGenerator
{
    List<string> motivations;
    public MotivationGenerator()
    {
         motivations = new List<string>
        {
            "You can do it!",
            "Any goal can be accomplished on step at a time!",
            "Just one small positive thought in the morning can change your whole day.",
            "You can do anything you put your mind to!",
            "Opportunities don't happen, you create them!",
            "It is never too late to be what you might have been.",
            "Success is not final; failure is not fatal: It is the courage to continue that counts — Winston S. Churchill",
            "The road to success and the road to failure are almost exactly the same. — Colin R. Davis",
            "I never dreamed about success. I worked for it. —Estée Lauder",
        };

    }
    public void Display()
    {
        var random = new Random();
        int index = random.Next(motivations.Count);
        string motivation = motivations[index];
        Console.WriteLine($"{motivation}");
    }

    public string GetRandomMotivation()
    {
        var random = new Random();
        int index = random.Next(motivations.Count);
        string prompt = motivations[index];
        return prompt;
    }
}