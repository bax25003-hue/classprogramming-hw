using System.Runtime.CompilerServices;
using System.Xml;

public class ReflectionActivity : Activity
{
    private string _responseMessage;
    private List<string> _promptList;
    private List<string> _questionList;
    public ReflectionActivity() : base(
        "Reflection Activity",
        "In this activity, you will be given a prompt, and you will reflect on moments in your life where you have shown resilience and strength. Thinking about these situations will help you apply these principles in your life."
    )
    {
        _responseMessage = "Now that you have pondered on the prompt for a few moments, answer to yourself the following questions:";
        _promptList = new List<string> { 
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless." 
        };
        _questionList = new List<string> {
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?", 
            "What made this time different than other times when you were not as successful?", 
            "What is your favorite thing about this experience?", 
            "What could you learn from this experience that applies to other situations?", 
            "What did you learn about yourself through this experience?", 
            "How can you keep this experience in mind in the future?", 
        };
    }
    public override void BeginActivity()
    {
        Console.Clear();

        Console.WriteLine("Get ready...");
        this.SpinnerWait(5);

        // Get a prompt and dispaly it
        Random random = new Random();
        string prompt = _promptList[random.Next(_promptList.Count)];
        Console.WriteLine(); // Blank Line
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine();

        // Once the user thinks of a response, have them press enter to continue
        Console.WriteLine();
        Console.WriteLine($"When you have something in mind, press enter to continue.");
        Console.ReadLine();

        // Display the response message
        Console.WriteLine(_responseMessage);
        Console.Write("You may begin in: ");
            this.CountWait(5); // Appends the counter to the end of the message

        // Loop through questions for the duration of secondsDuration;
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while( DateTime.Now < endTime )
        {
            string question = _questionList[random.Next(_questionList.Count)];
            Console.Write($"> {question} ");
            this.SpinnerWait(12);
            Console.WriteLine();
        }
    }
}
// Reflection Activity
// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
// After the starting message, select a random prompt to show the user such as:


// After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list

// After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
// It should continue showing random questions until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities."

