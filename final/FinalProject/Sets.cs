public class Sets
{
    private List<Exercise> _sets;
    private string _exerciseName;

    // Behaviors
    public Sets(List<Exercise> sets, string exerciseName)
    {
        _sets = sets;
        _exerciseName = exerciseName;
    }
    public string GetExerciseName()
    {
        return _exerciseName;
    }
}