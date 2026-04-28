namespace Sandbox2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Goodbye, Moon!");
        // This is a comment
        /*
        The command for creating a new project is:
        dotnet new console -o [name] --use-program-main
        */
        for (int i = 1; i < 10; i += 2)
        {
            Console.WriteLine($"Funny line {i}");
        }
    }
}
