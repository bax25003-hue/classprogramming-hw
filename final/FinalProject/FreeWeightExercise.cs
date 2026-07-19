public class FreeWeightExercise : ExerciseSet
{
    // Attributes:

    // Behaviors
    public FreeWeightExercise(string name, uint reps, uint weight) : base(name, reps, weight)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
    }
}