using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class OnceGoal : Goal
{
    // Attributes
    private bool _completed;

    // Behaviors
    public OnceGoal(string title, string desc, int points) : base(title, desc, points)
    {
        _completed = false;
    }
    public override void AdvanceGoal()
    {
        if (_completed == false)
        {
            _completed = true;
        }
    }
    public override void Display()
    {
        if ( _completed == false)
        {
            Console.WriteLine($"( ) {_title} ({_desc})");
        }
        else
        {
            Console.WriteLine($"(X) {_title} ({_desc})");
        }
    }
}