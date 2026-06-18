namespace Animal;
class Fox : Animal
{
    public Fox(string name) : base(name)
    {
    }

    // Overridden behavior
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'yip!'");
    }
}