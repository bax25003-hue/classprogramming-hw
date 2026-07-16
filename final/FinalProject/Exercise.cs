public abstract class Exercise
{
    // Attributes
    protected string _name;
    protected uint _reps;
    protected uint _weight;

    // Behaviors
    public Exercise(string name, uint reps, uint weight)
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
    public virtual uint GetWeight()
    {
        return _weight;
    }
    public virtual void ChangeValues(string name, uint reps, uint weight)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
    }
    public abstract List<string> GetMuscleGroups();
}