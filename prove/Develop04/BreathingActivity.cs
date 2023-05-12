using System;

public class BreathingActivity : Activity
{
    private string _instruction1 = "Breathe in...";
    private string _instruction2 = "Now breathe out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void Breathing(int seconds)
    {
        Console.WriteLine();  
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();  
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_instruction1}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_instruction1.Length + 2));  
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_instruction1}  ");  
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_instruction2}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_instruction2.Length + 2));  
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_instruction2}  ");  
        }
    }
}