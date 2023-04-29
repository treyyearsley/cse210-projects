using System;
using System.Collections.Generic;

class PromptGenerator
{
    List<string> prompts;
    public PromptGenerator()
    {
         prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you do for fun today?",
            "What did you eat today?",
            "How did you live in the moment today?",
            "What scriptures have you read today?"
        };

    }
    public void Display()
    {
        var random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        Console.WriteLine($"{prompt}");
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }
}