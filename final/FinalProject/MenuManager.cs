using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class MenuManager
{
    // Behaviors:

    // Top menu and associated methods
    public uint TopMenu()
    {
        Console.Clear();
        Console.WriteLine("Options:");
        Console.WriteLine("  1. Start Workout");
        Console.WriteLine("  2. Save completed workout to existing file");
        Console.WriteLine("  3. Load workouts from file");
        Console.WriteLine("  4. Quit\n");
        Console.Write("Select an option: ");
        string userInput = Console.ReadLine();
        uint result = uint.Parse(userInput);
        return result;
    }

    // Workout menu and associated methods
    public uint WorkoutMenu()
    {
        Console.WriteLine("Options:");
        Console.WriteLine("  1. Add a set");
        Console.WriteLine("  2. Next exercise");
        Console.WriteLine("  3. Show current workout time");
        Console.WriteLine("  4. Finish workout");
        Console.Write("Select an option: ");
        string userInput = Console.ReadLine();
        uint result = uint.Parse(userInput);
        return result;
    }
    public void NewExercise(Sets sets)
    {
        string exerciseName = sets.GetExerciseName();
        Console.WriteLine($"New set for: {exerciseName}");

        Console.Write("How many reps did you do? ");
        string userInput = Console.ReadLine();
        uint reps = uint.Parse(userInput);

        Console.Write("At what weight (combined)? ");
        userInput = Console.ReadLine();
        uint weight = uint.Parse(userInput);

        Console.Write("Is it a machine (1) or free-weight (2) exercise? ");
        userInput = Console.ReadLine();
        int exerciseType = int.Parse(userInput);

        // New Exercise object
        if (exerciseType == 1)
        {
            Console.Write("What is the cable ratio of the machine, as a decimal (e.g. '0.5', which means 2:1)? ");
            userInput = Console.ReadLine();
            double cableRatio = double.Parse(userInput);
            ExerciseSet exerciseSet = new MachineExercise(exerciseName, reps, weight, cableRatio);

            sets.AddSet(exerciseSet);
        }
        else if (exerciseType == 2)
        {
            ExerciseSet exerciseSet = new FreeWeightExercise(exerciseName, reps, weight);

            sets.AddSet(exerciseSet);
        }
        Console.WriteLine("\n");
    }
    public Sets NewSetsObject(Workout workoutContainer)
    {
        Console.Write("What is your next exercise? ");
        string exerciseName = Console.ReadLine();

        Console.Write("What muscle groups does this exercise use? ");
        string muscleGroups = Console.ReadLine();

        Sets sets = new Sets([], exerciseName, muscleGroups);

        workoutContainer.AddSets(sets);

        Console.WriteLine("\n");

        return sets;
    }
    public void TimerMinutesAndSeconds(Timer timer)
    {
        string timerString = timer.MinutesAndSeconds();
        Console.WriteLine($"\nTotal elapsed time: {timerString}\n");
    }
}