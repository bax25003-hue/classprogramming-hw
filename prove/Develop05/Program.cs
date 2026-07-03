using System;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices.Swift;

// Extra features added: 
    // Added a Load overwrite confirmation if you have pre-existing goals
    // Operation Boxtape: Prevent re-completion of an already completed goal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

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
                    Console.Write("What is the bonus for accomplishing it that many times? ");
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
                DisplayGoalList(goals);
                
                Console.WriteLine();
                Console.WriteLine($"You have {totalPoints} points.");
            }


            // Save (format: "{Goal.ClassName}--{_title}--{_desc}--{_points}")
            if (menuInput == 3)
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string fileNameInput = Console.ReadLine();
                string filePath = $".\\{fileNameInput}.csv";

                // Writes each goal to the file
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    // Write total points
                    file.WriteLine(totalPoints);

                    // Record each goal
                    foreach (Goal goal in goals)
                    {
                        file.WriteLine(goal.GetSaveString());
                    }
                }
            }
           

            // Load (format: "{Goal.ClassName}--{_title}--{_desc}--{_points}")
            if (menuInput == 4)
            {
                // Check for existing files, 'continue' upon confirmation
                if (goals.Count() > 0)
                {
                    Console.WriteLine("WARNING: You have existing goals! Are you sure you want to overwrite them?");
                    Console.Write("Type 'Yes' to confirm (case sensitive), type anything else to abort: ");
                    string overwriteInput = Console.ReadLine();
                    if (overwriteInput == "Yes")
                    {
                        // Nothing; continue with the loop and overwrite the existing files
                    }
                    else
                    {
                        continue; // Restarts up to the menu while loop, aborting changing files
                    }
                }
                // Reset List<Goal> for redundancy's sake, see above if statement
                goals = null;
                goals = new List<Goal>();

                // Get and load file
                Console.Write("What is the filename for the goal file? ");
                string fileNameInput = Console.ReadLine();
                string filePath = $".\\{fileNameInput}.csv";
                string[] lines = System.IO.File.ReadAllLines(filePath);
                int count = lines.Length;

                // Record total points from lines[0]
                totalPoints = uint.Parse(lines[0]);

                // For the remaining lines, separate text into parts
                for (int i = 1; i < count; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split("--");
                    // Calculate goal type based on parts[0]
                    // Initialize each goal, reset the list, and add each goal to the list
                        // NOTE: This cannot be included as a method because no Goal class exists yet to
                        // run the method; no Goal has _title, _desc, and _points as optional arguments
                    if (parts[0] == "OnceGoal")
                    {
                        // Save parts to variables
                        string fileTitle = parts[1];
                        string fileDesc = parts[2];
                        uint filePoints = uint.Parse(parts[3]);
                        bool fileCompleted = bool.Parse(parts[4]);

                        // New Goal class with respective attributes
                        // Ignore parts[0] because that is a lambda property and not a settable field
                        OnceGoal fileOnceGoal = new OnceGoal(fileTitle, fileDesc, filePoints, fileCompleted);

                        // Add OnceGoal to List<Goal>
                        goals.Add(fileOnceGoal);
                    }
                    else if (parts[0] == "PersistentGoal")
                    {
                        // Save parts to variables
                        string fileTitle = parts[1];
                        string fileDesc = parts[2];
                        uint filePoints = uint.Parse(parts[3]);

                        // New Goal class with respective attributes
                        // Ignore parts[0] because that is a lambda property and not a settable field
                        PersistentGoal filePersistentGoal = new PersistentGoal(fileTitle, fileDesc, filePoints);

                        // Add PersistentGoal to List<Goal>
                        goals.Add(filePersistentGoal);
                    }
                    else if (parts[0] == "CheckpointGoal")
                    {
                        // Save parts to variables
                        string fileTitle = parts[1];
                        string fileDesc = parts[2];
                        uint filePoints = uint.Parse(parts[3]);
                        // uint maxCount, uint bonusPoints, uint currentCount = 0, bool completed = false
                        uint fileMaxCount = uint.Parse(parts[4]);
                        uint fileBonusPoints = uint.Parse(parts[5]);
                        uint fileCurrentCount = uint.Parse(parts[6]);
                        bool fileCompleted = bool.Parse(parts[7]);

                        // New Goal class with respective attributes
                        // Ignore parts[0] because that is a lambda property and not a settable field
                        CheckpointGoal fileCheckpointGoal = new CheckpointGoal(fileTitle, fileDesc, filePoints, fileMaxCount, fileBonusPoints, fileCurrentCount, fileCompleted);

                        // Add CheckpointGoal to List<Goal>
                        goals.Add(fileCheckpointGoal);
                    }
                }
            } // End file-loading logic

            // Advance a goal forward
            if (menuInput == 5)
            {
                Console.WriteLine("The goals are: ");
                DisplayGoalList(goals);
                Console.Write("Which goal did you accomplish? ");
                string selectionInput = Console.ReadLine();
                int goalSelection = int.Parse(selectionInput);

                // Logic to select and advance goal
                int goalsIndex = goalSelection - 1;
                bool? advanceResult = goals[goalsIndex].AdvanceGoal(); // 'bool?' implies that it can also return 'null'

                // Checks for a null return value, which signifies a goal that is already completed
                if (advanceResult is null)
                {
                    Console.WriteLine("Sorry, this goal has already been completed. Please try again.");
                    Console.WriteLine();
                    Console.WriteLine($"You still have {totalPoints} points.");
                    continue; // Breaks the loop, stops points from being added, and returns to the menu
                }
                uint earnedPoints = goals[goalsIndex].GetPoints();
                Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
                totalPoints += earnedPoints;
                Console.WriteLine($"You now have {totalPoints} points.");
            }

            // Quit
            if (menuInput == 6)
            {
                break;
            }

        } // Head menu

    } // End of Main()

    static void DisplayGoalList(List<Goal> goalList) 
    {
        foreach (Goal goal in goalList)
            {
                int currentIndex = goalList.IndexOf(goal);
                Console.Write($"{currentIndex + 1}. ");
                goal.Display(); // the .Display() method uses Console.Write()
                Console.WriteLine(); // newline
            }
    }
}