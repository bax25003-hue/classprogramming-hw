using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Jace Baxter", "Kinetic and Potential Energy");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Jace Baxter", "Fractions", "7.3", "7-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Jace Baxter", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}