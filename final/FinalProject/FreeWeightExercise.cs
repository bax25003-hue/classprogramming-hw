public abstract class FreeWeightExercise : Exercise
{
    // Attributes:
    
    // Behaviors
    // No extra functionality, just a constructor
    public FreeWeightExercise(string name, uint reps, uint weight) : base(name, reps, weight)
    {
        _name = name;
        _reps = reps;
        _weight = weight;
    }
    // This class needed to be implemented not for added functionality but simply to serve as a counterpart to MachineExercise, which does have added functinality
}