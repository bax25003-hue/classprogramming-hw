using System;

class Program
{
    static void Main(string[] args)
    {
        // Things to test: 
        // 1. Exercise Getter Methods
        List<Exercise> exerciseList = new List<Exercise>{};
        CompoundFreeWeightExercise cfwe = new CompoundFreeWeightExercise("Bench Press", 10, 85, new List<string>{"Chest", "Triceps", "Front Delts"});
        exerciseList.Add(cfwe);

        CompoundMachineExercise cme = new CompoundMachineExercise("Hack Squat", 10, 90, new List<string>{"Quadriceps", "Glutes"}, 0.75);
        exerciseList.Add(cme);

        IsolatedFreeWeightExercise ifwe = new IsolatedFreeWeightExercise("Bicep Curl (Dumbell)", 10, 40, "Biceps");
        exerciseList.Add(ifwe);

        IsolatedMachineExercise ime = new IsolatedMachineExercise("Tricep Pulldown", 10, 20, "Triceps");
        exerciseList.Add(ime);

        foreach (Exercise exercise in exerciseList)
        {
            Console.WriteLine(exercise.GetName());
            Console.WriteLine(exercise.GetReps());
            Console.WriteLine(exercise.GetWeight());
            foreach (string muscleGroup in exercise.GetMuscleGroups())
            {
                Console.Write($"{muscleGroup}, ");
            }
            Console.WriteLine("\n");
        }

        // 2. Timer Start and Stop Methods


        // 3. Timer TimeStamp Method
    }
}