class Circle : RoundShape
{
    // Attributes
    protected double _radius;

    // Behaviors
    public Circle(double r)
    {
        _radius = r;
    }
    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}