using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        ReflectionActivity reflectionActivity = new ReflectionActivity();
    }
}
// Solution Idea
// Consider an app that provides three different kinds of mindfulness opportunities. It could give some guidance and structure to users in the following activities:

// Breathing Activity - Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.
// Reflection Activity - Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.
// Listing Activity - Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.
// The application could additional help the user keep track of the time or frequency they spend in these activities and give them gentle prompts and reminders.

// The user interface of a program like this could be anything from a Website or Mobile App to one that runs on a Smart Watch and it could be done in many different kinds of colors, shapes, and styles. Learning to write a program to solve the real-world problem is the most critical part, so this assignment will focus on that, rather than creating a flashy interface.
// Specification
// Write a program that provides the three activities described above. It should help them work through these activities in stages using basic forms of delay (animation or countdown).

// Functional requirements
// Your program must do the following:

// Have a menu system to allow the user to choose an activity.
// Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
// Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
// Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
// The interface for the program should remain generally true to the one shown in the video demo.
// Provide activities for reflection, breathing, and enumeration, as described below:
// Breathing Activity
// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
// The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
// After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
// After each message, the program should pause for several seconds and show a countdown.
// It should continue until it has reached the number of seconds the user specified for the duration.
// The activity should conclude with the standard finishing message for all activities.

