using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        // Init job1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1990;
        job1._endYear = 2008;

        // Init job2 
        Job job2 = new Job();
        job2._jobTitle = "Product Manager";
        job2._company = "Apple";
        job2._startYear = 2008;
        job2._endYear = 2025;


        // Init resume
        Resume resume = new Resume();
        resume._name = "Jace Baxter";
        resume._jobs = [job1, job2];

        // Display Resume
        resume.DisplayResume();
    }
}