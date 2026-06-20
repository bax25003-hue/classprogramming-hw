using System.Security.Principal;
using Microsoft.VisualBasic.FileIO;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 30;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");

        Console.WriteLine($"{_description}\n");

        Console.Write($"How long, in seconds, would you like for your session? ");
        string timeInput = Console.ReadLine();
        this._duration = int.Parse(timeInput);
    }
    public void SpinnerWait(int seconds)
    {   
        int duration = seconds * 5; // Convert seconds to number of spinner iterations
    
        // Make a spinner with |, /, -, and \
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < duration; i++)
        {   
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }
    public void CountWait(int duration)
    {
        // Count down from 'duration' to 1
        while ( duration > 0)
        {
            Console.Write(duration);
            int durationCharLength = duration.ToString().Length;
            duration -= 1;
            Thread.Sleep(1000);
            for (int i = durationCharLength; i > 0; i--)
            {
                Console.Write("\b \b");
            }
        }
    }
    public virtual void BeginActivity()
    {
        Console.WriteLine("If you are seeing this, the programmer messed up somewhere lol");
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done!");
        this.SpinnerWait(4);
        Console.WriteLine($"\nYou have completed another {this._duration} seconds of the {this._name}.");
        this.SpinnerWait(6);
    }

    // public void AskForDuration()
    // {
    //     Console.Write($"How long, in seconds, would you like for your session? ");
    //     string timeInput = Console.ReadLine();
    //     this._duration = int.Parse(timeInput);
    // }

}