namespace Animal;
class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    // Overridden behaviro
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'meow'");
    }
}