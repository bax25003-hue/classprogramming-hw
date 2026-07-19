public class Sets
{
    private List<ExerciseSet> _sets;
    private string _exerciseName;
    private string _muscleGroups;

    // Behaviors
    public Sets(List<ExerciseSet> sets, string exerciseName, string muscleGroups)
    {
        _sets = sets;
        _exerciseName = exerciseName;
        _muscleGroups = muscleGroups;
    }
    public List<ExerciseSet> GetExerciseSetList()
    {
        return _sets;
    }
    public string GetExerciseName()
    {
        return _exerciseName;
    }
    public void AddSet(ExerciseSet set)
    {
        _sets.Add(set);
    }
    public string GetMuscleGroups()
    {
        return _muscleGroups;
    }
    public string GetSaveString()
    {
        return $"Sets|{_exerciseName}|{_muscleGroups}";
    }
}