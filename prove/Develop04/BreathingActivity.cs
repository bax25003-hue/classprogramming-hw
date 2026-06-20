// Breathing Activity - Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.

// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
// After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
// After each message, the program should pause for several seconds and show a countdown.
// It should continue until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities.

public class BreathingActivity : Activity
{
    // Attributes: none
    // Behaviors
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    {
    }
    public override void BeginActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        this.SpinnerWait(5);

        // Breath in and out for the duration of the activity 
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while ( DateTime.Now < endTime)
        {
            Console.WriteLine();

            Console.Write("Breath in... ");
            this.CountWait(3);
            Console.WriteLine();
            
            Console.Write("Now breath out... ");
            this.CountWait(4);
            Console.WriteLine();
        }
    }
}