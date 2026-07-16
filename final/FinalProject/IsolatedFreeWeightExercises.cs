public class IsolatedFreeWeightExercise : FreeWeightExercise
{
    // Attributes
    private string _muscleGroup;
    
    // Behaviorss
    public IsolatedFreeWeightExercise(string name, uint reps, uint weight, string muscleGroup) : base(name, reps, weight)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
        _muscleGroup = muscleGroup;
    }
    public override List<string> GetMuscleGroups()
    {
        return new List<string> { _muscleGroup };
    }
}