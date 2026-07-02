using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class OnceGoal : Goal
{
    // Attributes
    private bool _completed;

    // Behaviors
    public OnceGoal(string title, string desc, uint points, bool completed = false) : base(title, desc, points)
    {
        _completed = completed;
    }
    public override void Display()
    {
        if ( _completed == false)
        {
            Console.Write($"( ) {_title} ({_desc})");
        }
        else
        {
            Console.Write($"(X) {_title} ({_desc})");
        }
    }
    public override bool AdvanceGoal()
    {
        if (_completed == false)
        {
            _completed = true;
        }
        return _completed;
    }
}