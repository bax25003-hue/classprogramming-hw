public abstract class MachineExercise : Exercise
{
    // Attributes
    protected double _cableRatio;

    // Behaviors
    public MachineExercise(string name, uint reps, uint weight, double cableRatio = 1) : base(name, reps, weight)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
        _cableRatio = cableRatio;
    }
    public override uint GetWeight()
    {
        uint roundedWeight = (uint)Math.Round(_weight * _cableRatio, 0);
        return roundedWeight;
    }
}