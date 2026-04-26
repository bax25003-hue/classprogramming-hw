using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // Gets a number from the user and converts it to int
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        // Grade Comparison
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        // Code to append + or - if needed
        int plusMinus = (grade % 10);

        string symbol = "";
        if (plusMinus <=3)
        {
            if (letter == "F")
            {
                // Pass
            }
            else
            {
                symbol = "-";
            }
        }
        else if (plusMinus >= 7)
        {
            if (letter == "A" || letter == "F")
            {
                // Pass
            }
            else
            {
                symbol = "+";
            }
        }
        else
        {
            // No symbol is set
        }

    // Prints the letter gradek, and symobl if present
        if (letter == "A" || letter == "F")
        {
            Console.Write($"You got an {letter}{symbol}");
        }
        else
        {
            Console.Write($"You got a {letter}{symbol}");
        }


    }
}