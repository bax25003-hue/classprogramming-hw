namespace Animal;
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    // Overridden behaviro
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'bark!'");
    }
}