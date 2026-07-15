using System.Diagnostics.CodeAnalysis;

public class Workout
{
    // Attributes
    private List<Sets> _exercises;
    private uint _duration;
    private string _name;

    // Behaviors
    public Workout(List<Sets> exercises, uint duration, string name)
    {
        _exercises = exercises;
        _duration = duration;
        _name = name;
    }
}