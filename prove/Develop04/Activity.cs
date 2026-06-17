public class Activity
{
    protected string _name;
    protected string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
    }
    public void DisplaySpinner(int seconds)
    {   int duration = seconds * 5; // Convert seconds to number of spinner iterations
    
        // Make a spinner with |, /, -, and \
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < duration; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }
}