using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> activities = new List<string>();

        Activity activity1 = new Running("May 18, 2023", 75, 9.5);
        string summary1 = activity1.getSummary();
        activities.Add(summary1);
        Console.WriteLine();

        Activity activity2 = new Cycling("May 20, 2023", 110, 8.25);
        string summary2 = activity2.getSummary();
        activities.Add(summary2);
        Console.WriteLine();

        Activity activity3 = new Swimming("May 23, 2023", 55, 11);
        string summary3 = activity3.getSummary();
        activities.Add(summary3);
        Console.WriteLine();

        Activity activity4 = new Swimming("May 25, 2023", 60, 12);
        string summary4 = activity4.getSummary();
        activities.Add(summary4);
        Console.WriteLine();

        Activity activity5 = new Running("May 27, 2023", 35, 2);
        string summary5 = activity5.getSummary();
        activities.Add(summary5); 
        Console.WriteLine();       

        Activity activity6 = new Cycling("May 30, 2023", 25, 10);
        string summary6 = activity6.getSummary();
        activities.Add(summary6);
        Console.WriteLine();

        for(int count = 0; count < activities.Count; count++)
        {
            Console.WriteLine(activities[count]);
        }
    }
}