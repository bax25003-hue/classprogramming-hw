using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

public class FileManager
{
    public void WriteToFile(string inputString = "", string fileName = "workouts")
    {
        string filePath = $".\\{fileName}.csv";
        File.AppendAllText(filePath, inputString + "\n");
    }
    public Workout LoadWorkouts(string fileName = "workouts")
    {
        string filePath = $".\\{fileName}.csv";
        
        // Reads the file
        string[] lines = System.IO.File.ReadAllLines(filePath);

        // Initial Workout and Set setup
        string line = lines[0];
        string[] parts = line.Split("|");

        Workout loadWorkout = new Workout([], parts[1], TimeSpan.Parse(parts[2])); // add parts[2] for TimeSpan after
        Sets loadSets = new Sets([], "", "");

        // Load the rest of the file
        for (int i = 1; i < lines.Length; i++)
        {
            line = lines[i];
            parts = line.Split("|");

            if (parts[0] == "Workout")
            {
                loadWorkout = new Workout([], parts[1], TimeSpan.Parse(parts[2]));
            }
            if (parts[0] == "Sets")
            {
                loadSets = new Sets([], parts[1], parts[2]);
                loadWorkout.AddSets(loadSets);
            }
            else if (parts[0] == "FreeWeightExercise")
            {
                FreeWeightExercise loadFreeWeightExercise = new FreeWeightExercise(parts[1], uint.Parse(parts[2]), uint.Parse(parts[3]));
                loadSets.AddSet(loadFreeWeightExercise);
            }
            else if (parts[0] == "MachineExercise")
            {
                MachineExercise loadMachineExercise = new MachineExercise(parts[1], uint.Parse(parts[2]), uint.Parse(parts[3]), double.Parse(parts[4]));
                loadSets.AddSet(loadMachineExercise);
            }
        }
        return loadWorkout;
    }
}