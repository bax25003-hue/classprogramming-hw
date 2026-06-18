namespace Animal;
class Animal
{
    // Attributes
    protected string _name;

    // Behaviors
    public Animal(string name)
    {
        _name = name;
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine($"{_name} says thes same thing every animal says.");
    }

}