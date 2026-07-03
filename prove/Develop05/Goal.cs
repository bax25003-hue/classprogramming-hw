public class Goal
{
    // Attributes
    protected string ClassName => this.GetType().Name; 
        // Explanation: I didn't want to set up a distinct method to get the class name, so I just made sure that  
    protected string _title;
    protected string _desc;
    protected uint _points; // The value of points awarded by completing the goal

    // Behaviors
    public Goal(string title, string desc, uint points)
    {
        _title = title;
        _desc = desc;
        _points = points;
    }
    public virtual void Display()
    {
        Console.Write($"( ) {_title} ({_desc})");
    }
    public virtual string GetSaveString()
    {
        return $"{this.ClassName}--{_title}--{_desc}--{_points}";
    }
    public virtual uint GetPoints()
    {
        return _points;
    }
    public virtual void AdvanceGoal()
    {
        // Logic to be added in child goals:
            // Every goal has unique completion logic to be written, therefore it
            // shouldn't be written here.
    }
}