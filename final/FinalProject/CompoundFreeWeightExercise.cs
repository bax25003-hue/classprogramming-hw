using System.Security.AccessControl;

public class CompoundFreeWeightExercise : FreeWeightExercise
{
    // Attributes
    private List<String> _muscleGroups;
    
    // Behaviors
    public CompoundFreeWeightExercise(string name, uint reps, uint weight, List<String> muscleGroups) : base(name, reps, weight)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
        _muscleGroups = muscleGroups;
    }
    public override List<string> GetMuscleGroups()
    {
        return _muscleGroups;
    }
}