using System.ComponentModel;

class PersistentGoal : Goal
{
    // Attributes: none

    // Behaviors:
    public PersistentGoal(string title, string desc, uint points) : base(title, desc, points)
    {
    }
    // No need to override AdvanceGoal, as it already returns FALSE; PersistentGoals cannot be "completed" and 
    // therefore should always return FALSE

    // No need to override Display; Display() already returns everything needed, and no separate "completed goal" logic is required 
    // to display for this type of goal
}