using System;
using System.IO;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        MotivationGenerator m = new MotivationGenerator();

        GoalManagement goals = new GoalManagement();

        Console.Clear();  
        Console.Write("\n*** Welcome to the Eternal Quest Program ****\n");

        Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");

        int             menuUserInput = 0;
        List<string>    menu = new List<string>
        {
            "Please select one of the following choices:",
            "1. Create New Goal",
            "2. List Goals",    
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Goal Event",
            "6. Find Motivation",
            "7. Quit",
        };

    while (menuUserInput != 7)
    {
        foreach(string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }
        menuUserInput = Int32.Parse(Console.ReadLine());

        if (menuUserInput == 1)
            {
                int             goalMenuUserInput = 0;
                List<string>    goalMenu = new List<string>
                {
                    "The Types of Goals are:",
                    "1. Simple Goal",
                    "2. Eternal Goal",
                    "3. Checklist Goal",
                    "4. Quit",
                    "Which type of goal do you want to create?",
                };
            while (goalMenuUserInput != 4)
            {
                foreach(string goalMenuItem in goalMenu)
                {
                    Console.WriteLine(goalMenuItem);
                }
                goalMenuUserInput = Int32.Parse(Console.ReadLine());

                if (goalMenuUserInput == 1)
                {
                    Console.WriteLine("What is the name of your goal?  ");
                    string name = Console.ReadLine();
                    name = textInfo.ToTitleCase(name);
                    Console.WriteLine("What is a short description of your goal?  ");
                    string description = Console.ReadLine();
                    description = textInfo.ToTitleCase(description);
                    Console.Write("What is the amount of points associated with this goal?  ");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                    goals.AddGoal(sGoal);
                    goalMenuUserInput = 5;
                }

                else if (goalMenuUserInput == 2)
                {
                    Console.WriteLine("What is the name of your goal?  ");
                    string name = Console.ReadLine();
                    name = textInfo.ToTitleCase(name);
                    Console.WriteLine("What is a short description of your goal?  ");
                    string description = Console.ReadLine();
                    description = textInfo.ToTitleCase(description);
                    Console.Write("What is the amount of points associated with this goal?  ");
                    int points = int.Parse(Console.ReadLine());
                    EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                    goals.AddGoal(eGoal);
                    goalMenuUserInput = 5;
                }
                else if (goalMenuUserInput == 3)
                {
                    Console.WriteLine("What is the name of your goal?  ");
                    string name = Console.ReadLine();
                    name = textInfo.ToTitleCase(name);
                    Console.WriteLine("What is a short description of your goal?  ");
                    string description = Console.ReadLine();
                    description = textInfo.ToTitleCase(description);
                    Console.Write("What is the amount of points associated with this goal?  ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                    int numberTimes = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times?  ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                    goals.AddGoal(clGoal);
                    goalMenuUserInput = 5;
                }
                else
                {
                    Console.WriteLine("Thank you for using the goal creater!");
                }
            }
            }
            

            else if (menuUserInput == 2)
            {
                Console.Clear();  
                Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                goals.ListGoals();
            }
            else if (menuUserInput == 3)
            {
                goals.SaveGoals();
            }
            else if (menuUserInput == 4)
            {
                Console.Clear();
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.LoadGoals();
            }
            else if (menuUserInput == 5)
            {
                Console.Clear();  
                Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                goals.RecordGoalEvent();
            }
            else if (menuUserInput == 6)
            {
                string motivation = m.GetRandomMotivation();
                Console.WriteLine(motivation);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Thanks for using the Eternal Quest Program!");
            }
        // To make the program my own I added a getmotivation class that returns a motivational phrase.

    }
    }

}
