using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        
        // Tasks: 
        // Objective: Scripture initializes Word and Reference and displays full scripture. "Enter" to hide three random words (no need to check if word is already hidden). Exit when completely hidden or "quit" is typed. 

        // Initialize Scripture, which auto-initializes Reference and List<Word>
        Scripture scripture = new Scripture("Nephi", 2, 25, new List<string> {"Adam", "fell", "that", "men", "might", "be;", "and", "men", "are,", "that", "they", "might", "have", "joy."});
        scripture.DisplayScripture();

        // Loop until scripture is completed or user types "quit"
        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            scripture.HideWords();
            scripture.DisplayScripture();
        }
        while (!scripture.CheckCompletion());

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }
}