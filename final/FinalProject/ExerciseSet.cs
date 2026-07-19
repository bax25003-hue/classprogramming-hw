using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

public abstract class ExerciseSet
{
    // Enum


    // Attributes
    protected string ClassName => this.GetType().Name; 
    protected string _name;
    protected uint _reps;
    protected uint _weight;

    // Behaviors
    public ExerciseSet(string name, uint reps, uint weight)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
    }
    public string GetName()
    {
        return _name;
    }
    public uint GetReps()
    {
        return _reps;
    }
    public virtual uint GetWeight() // Affected by cable ratio for MachineExercise objects
    {
        return _weight;
    }
    public virtual void ChangeValues(uint reps, uint weight) // Only weight and reps, the rest are fixed facts about an exercise
    {
        _reps = reps;
        _weight = weight;
    }
    public virtual string GetSaveString()
    {
        return $"{ClassName}|{_name}|{_reps}|{_weight}";
    }
}