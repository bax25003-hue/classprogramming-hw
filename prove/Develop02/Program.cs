using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

// Exceeding requirements: The instructions were conflicting as to whether I should save
// the file as a .csv or as a .txt, so I did both. However, only the .csv is implemented; if
// you want to test the other one you will have to uncomment the particular code and comment 
// the existing .csv code in the Journal.cs file.


class Program
{
    static void Main(string[] args)
    {
        // Setup
        Journal myJournal = new(); // Could also do "new Journal();"
        myJournal._entries = [];
        myJournal._filePath = "";

        // Menu loop
        int option = 0;
        string userInput;
        Console.WriteLine("Booting JournalWriter.exe...\n");
        Console.WriteLine("Welcome to the Journal Writing Program!");
        do
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("(1) Start a new entry");
            Console.WriteLine("(2) Display all entries in the journal");
            Console.WriteLine("(3) Save to file");
            Console.WriteLine("(4) Load a journal from a file");
            Console.WriteLine("(5) Quit");
            Console.Write("Enter a number to choose an option: ");
            userInput = Console.ReadLine();
            option = int.Parse(userInput);
            if (option == 1)
            {
                myJournal.AddEntry();
            }
            else if (option == 2)
            {
                myJournal.DisplayEntries();
            }
            else if (option == 3)
            {
                myJournal.Save();
            }
            else if (option == 4)
            {
                myJournal.Load();
            }
            else if (option == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Oops! That's not an option, please choose again.");
            }
        }
        while (option != 5);
        Console.WriteLine("\n\nThakns for using my Journal Writing Program! Goodbye.");
    }
}