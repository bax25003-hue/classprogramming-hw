using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Dynamic;
using System.IO.Pipelines;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        // TESTING NOTES:
        // MAKE SURE THAT cableRatio CORRECTLY DEFAULTS TO 1



        // Menu
        MenuManager menus = new MenuManager();
        List<Sets> tempSetList = new();
        Workout workout = new(tempSetList, "");
        
        while (true)
        {
            uint result = menus.TopMenu();

            if (result == 1) // Start workout
            {
                Console.Clear();
                Console.WriteLine("Starting workout... \n\n");
                Thread.Sleep(2000);

                Console.Write("What do you want to name this workout session? ");
                string workoutName = Console.ReadLine();
                workout.SetName(workoutName);

                Timer workoutTimer = new Timer();
                workoutTimer.StartTimer(DateTime.Now);

                // Initial workout exercise
                Console.Write("What exercise are you starting with? ");
                string exerciseTitle = Console.ReadLine();

                Console.Write("What muscle groups does this exercise use (e.g. 'Biceps, Lats')? ");
                string muscleGroups = Console.ReadLine();

                Sets sets = new Sets([], exerciseTitle, muscleGroups);
                workout.AddSets(sets);

                Console.WriteLine("\n");

                // Workout menu loop
                while (true)
                {
                    // Workout menu loop
                    result = menus.WorkoutMenu();

                    if (result == 1) // New ExercisSet object "New set"
                    {
                        menus.NewExercise(sets);
                    } 

                    else if (result == 2) // New Sets object "Next type of exercise"
                    {
                        sets = menus.NewSetsObject(workout);
                    }

                    else if (result == 3) // Display workout timer
                    {
                        menus.TimerMinutesAndSeconds(workoutTimer);
                    }
                    else if (result == 4) // End workout
                    {
                        Console.WriteLine("\nEnding Workout...");

                        // Get and print the current timestamp
                        TimeSpan timestamp = workoutTimer.Timestamp();
                        workout.SetDuration(timestamp);
                        workout.SetDuration(timestamp);
                        Console.WriteLine($"Workout duration: {workoutTimer.MinutesAndSeconds()}\n");
                        break;
                    }
                    
                }
            } // End workout menu

            else if (result == 2) // Save workout
            {
                FileManager saver = new();
                List<Sets> setList = workout.GetSetList();

                // TESTING
                saver.WriteToFile(workout.GetSaveString());

                // Writes the workout name, a header (set group) for each exercise, then each set of the respective exercise
                foreach (Sets writeSets in workout.GetSetList())
                {
                    saver.WriteToFile(writeSets.GetSaveString());
                    foreach (ExerciseSet exerciseSet in writeSets.GetExerciseSetList())
                    {
                        saver.WriteToFile(exerciseSet.GetSaveString());
                    }
                }
            }

            else if (result == 3)
            {
                workout = null;
                FileManager loader = new FileManager();
                workout = loader.LoadWorkouts("workouts");
                Console.WriteLine(workout.GetName());
            }
            else if (result == 4)
            {
                break;
            }
            
            // Testing the load function
            else if (result == 5)
            {
                Console.WriteLine(workout.GetSaveString());
                Console.WriteLine(workout.GetSetList()[0].GetSaveString());
                Console.WriteLine(workout.GetSetList()[0].GetExerciseSetList()[0].GetSaveString());
            }
        }
    }
}