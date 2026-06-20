// Listing Activity
// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
// After the starting message, select a random prompt to show the user such as:

// Who are people that you appreciate?
// What are personal strengths of yours?
// Who are people that you have helped this week?
// When have you felt the Holy Ghost this month?
// Who are some of your personal heroes?

// After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
// The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
// The activity them displays back the number of items that were entered.
// The activity should conclude with the standard finishing message for all activities.

using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    // Attributes
    private List<string> _promptList;

    // Behaviors
    public ListingActivity() : base(
        "Listening Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    {
        _promptList = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public override void BeginActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        this.SpinnerWait(5);

        // Get a random prompt
        Random random = new Random();
        string prompt = _promptList[random.Next(_promptList.Count)];

        Console.WriteLine("List as many responses as you can for the following prompt:");
        Console.WriteLine($" --- {prompt} --- ");
        Console.Write("You may begin in: ");
            this.CountWait(15);

        // Allow the user to respond to messages for their requested time
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int listCount = 0; // To count the number of user responses
        while ( DateTime.Now < endTime )
        {
            Console.Write("> ");
            Console.ReadLine();
            listCount += 1;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {listCount} items!");
    }
}

