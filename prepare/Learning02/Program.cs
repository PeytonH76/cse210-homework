using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        //                <Creating a new object>
        //Class variableName = new Object()
        Job job1 = new Job();
        // The way the class wants is commented
        Console.Write("What is your job title? ");
        job1._jobTitle = Console.ReadLine();
        //job1._jobTitle = "Software Engineer";
        Console.Write("What is your company? ");
        job1._company = Console.ReadLine();
        //job1._company = "Microsoft";
        Console.Write("When did you start? ");
        job1._startYear = int.Parse(Console.ReadLine());
        //job1._startYear = 1290;
        Console.Write("When did you end? ");
        job1._endYear = int.Parse(Console.ReadLine());
        //job1._endYear = 1370;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        
        job1.Display();
        Console.WriteLine();

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        Console.WriteLine();
    }
}