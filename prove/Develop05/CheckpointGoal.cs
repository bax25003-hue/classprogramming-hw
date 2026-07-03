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
        _maxCount = maxCount;
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
    public override string GetSaveString()
    {
        return $"{this.ClassName}--{_title}--{_desc}--{_points}--{_maxCount}--{_bonusPoints}--{_currentCount}--{_completed}";
    }
    public override void AdvanceGoal()
    {
        // Cannot re-complete this type of goal
        if (_completed == true)
        {
            Console.WriteLine("Sorry, this goal has already been completed. Please try again.");
            return;
        }
        // Otherwise, adds to completion counter, completes when _maxCount is reached
        _currentCount += 1;
        if ( _currentCount == _maxCount)
        {
            _completed = true;
        }
    }
    public override uint GetPoints()
    {
        if (_completed == false)
        {
            return _points;
        }
        else
        {
            return _points + _bonusPoints;
        }
    }
}