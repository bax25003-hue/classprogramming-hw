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
    public override string GetSaveString()
    {
        return $"{this.ClassName}--{_title}--{_desc}--{_points}--{_completed}";
    }
    public override bool? AdvanceGoal()
    {
        // Cannot re-complete this type of goal
        if (_completed == true)
        {
            return null;
        }

        // Otherwise, completes the goal
        if (_completed == false)
        {
            _completed = true;
        }
        return _completed;
    }

}