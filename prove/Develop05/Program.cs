using System;
using System.ComponentModel.Design;
using System.Net.Security;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        // AdvanceGoal methods return the value of _completed

        // To-do: Implement the following:

        Console.WriteLine("Hello there! Welcome to your goal-setting program!");

        // Session variables
        List<Goal> goals = new List<Goal>();
        uint totalPoints = 0;

        // Menu loop
        while (true) // runs until "break"
        {
            // Parent menu
            Console.WriteLine();

            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            // Reads user input and saves it to a variable
            string userInput = Console.ReadLine();
            uint menuInput = uint.Parse(userInput);
            Console.WriteLine(); // spacing

            // Menu logic: 
            // New Goal
            if (menuInput == 1)
            {
                // New Goal menu
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Persistent Goal");
                Console.WriteLine("  3. Checkpoint Goal");
                Console.Write("Which type of goal would you like to create? ");
                string userNewGoalInput = Console.ReadLine();
                uint newGoalInput = uint.Parse(userNewGoalInput); // used later for goal type

                // Title
                Console.Write("What is the name of your goal? ");
                string goalTitle = Console.ReadLine();
                
                // Description
                Console.Write("What is a short description of it? ");
                string goalDesc = Console.ReadLine();
                
                // Completion/Advancement points
                Console.Write("What is the amount of points associated with this goal? ");
                string pointsInput = Console.ReadLine();
                uint goalPoints = uint.Parse(pointsInput);

                // Logic to create the specified goal
                if (newGoalInput == 1)
                {
                    OnceGoal onceGoal = new OnceGoal(goalTitle, goalDesc, goalPoints);
                    goals.Add(onceGoal); // Adds new goal
                }
                else if (newGoalInput == 2)
                {
                    PersistentGoal persistentGoal = new PersistentGoal(goalTitle, goalDesc, goalPoints);
                    goals.Add(persistentGoal); // Adds new goal
                }
                else if (newGoalInput == 3)
                {
                    // Requests additional arguments

                    // Max advancement count
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string maxGoalInput = Console.ReadLine();
                    uint goalMaxCount = uint.Parse(maxGoalInput);
                    

                    // Bonus points upon full completion
                    Console.Write("What isthe bonus for accomplishing it that many times ");
                    string bonusPointsInput = Console.ReadLine();
                    uint goalBonusPoints = uint.Parse(bonusPointsInput);

                    // Initialization
                    CheckpointGoal checkpointGoal = new CheckpointGoal(goalTitle, goalDesc, goalPoints, goalMaxCount, goalBonusPoints);
                    goals.Add(checkpointGoal); // Adds new goal
                }
            } // End new Goal menu


            // Display goals
            if (menuInput == 2)
            {
                foreach (Goal goal in goals)
                {
                    int currentIndex = goals.IndexOf(goal);
                    Console.Write($"{currentIndex + 1}. ");
                    goal.Display(); // the .Display() method uses Console.Write()
                    Console.WriteLine(); // newline
                } 
                
                Console.WriteLine();
                Console.WriteLine($"You have {totalPoints} points.");
            }


            // Save (format: "{this.ClassName}--{_title}--{_desc}--{_points}")
            
            // Load (format: "{this.ClassName}--{_title}--{_desc}--{_points}")
            
            // Advance a goal forward

            // Quit
            if (menuInput == 6)
            {
                break;
            }
        } // Head menu
    }
}