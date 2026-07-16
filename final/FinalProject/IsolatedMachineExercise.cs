public class IsolatedMachineExercise : MachineExercise
{
    // Attributes
    private string _muscleGroup;

    // Behaviors
    public IsolatedMachineExercise(string name, uint reps, uint weight, string muscleGroup, double cableRatio = 1) : base(name, reps, weight, cableRatio)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
        _muscleGroup = muscleGroup;
        _cableRatio = cableRatio;
    }
    public override List<string> GetMuscleGroups()
    {
        return new List<string> { _muscleGroup };
    }
}