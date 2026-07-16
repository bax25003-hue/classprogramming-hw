public class CompoundMachineExercise : MachineExercise
{
    // Attributes;
    private List<string> _muscleGroups;

    // Behaviors
    public CompoundMachineExercise(string name, uint reps, uint weight, List<string> muscleGroups, double cableRatio = 1) : base(name, reps, weight, cableRatio)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
        _muscleGroups = muscleGroups;
        _cableRatio = cableRatio;
    }
    public override List<string> GetMuscleGroups()
    {
        return _muscleGroups;
    }
}