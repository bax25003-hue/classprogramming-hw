using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Reflection;

public class CheckpointGoal : Goal
{
    // Attributes
    private bool _completed;
    private uint _maxCount;
    private uint _bonusPoints;
    private uint _currentCount;

    // Behaviors
    public CheckpointGoal(string title, string desc, uint points, uint maxCount, uint bonusPoints, uint currentCount = 0, bool completed = false) : base(title, desc, points)
    {
        _bonusPoints = bonusPoints;
        // _currentCount and _completed are FALSE by default.
        _currentCount = currentCount;
        _completed = completed;
    }
    public override void Display()
    {
        // Display ( ) title (description) -- Completed: currentCount/maxCount
        if ( _completed == false )
        {
            Console.Write($"( ) {_title} ({_desc}) -- Completed: {_currentCount}/{_maxCount} times");
        }
        else
        {
            Console.Write($"(X) {_title} ({_desc}) -- Completed: {_currentCount}/{_maxCount} times");
        }
    }
    public override bool AdvanceGoal()
    {
        // Adds to completion counter, completes when full 
        _currentCount += 1;
        if ( _currentCount == _maxCount)
        {
            _completed = true;
        }
        return _completed;
    }

}