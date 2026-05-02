using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int favoriteNumber = int.Parse(userInput);
        return favoriteNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string userInput = Console.ReadLine();
        birthYear = int.Parse(userInput);
    }

    static int SquareNumber(int number)
    {
        int newNumber = number * number;
        return newNumber;
    }

    static void DisplayResult(string username, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{username}, the square of your number is {squaredNumber}");
        int currentYear = DateTime.Now.Year;
        int yourAge = currentYear - birthYear;
        Console.WriteLine($"You will turn {yourAge} this year!");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);

        // User birth year out variable
        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, birthYear);
    }
}