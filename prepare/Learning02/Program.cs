using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2023;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Tester";
        job2._startYear = 2027;
        job2._endYear = 2029;

        Resume myResume = new Resume();
        myResume._name = "Trey Yearsley";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}