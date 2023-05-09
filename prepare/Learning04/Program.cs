using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment1 = new Assignment("Trey Yearsley", "Division");
        Console.WriteLine(assignment1.GetSummary());

        
        MathAssignment assignment2 = new MathAssignment("Anna Yearsley", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Zander Yearsley", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}