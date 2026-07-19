using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

public class Workout
{
    // Attributes
    private List<Sets> _setList;
    private string _name;
    private TimeSpan? _duration;

    // Behaviors
    public Workout(List<Sets> setList, string name = "", TimeSpan? duration = null)
    {
        _setList = setList;
        _name = name;
        _duration = duration;

    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public TimeSpan? GetDuration()
    {
        return _duration;
    }
    public void SetDuration(TimeSpan duration)
    {
        _duration = duration;
    }
    public List<Sets> GetSetList()
    {
        return _setList;
    }
    public string GetSaveString()
    {
        return $"Workout|{_name}|{_duration}";
    }
    public void AddSets(Sets exerciseName)
    {
        _setList.Add(exerciseName);
    }
}