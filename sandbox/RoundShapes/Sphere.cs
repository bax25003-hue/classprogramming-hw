class Sphere : Circle
{
    // Attributes
    // none

    // Behaviors
    // Behaviors
    public Sphere(double r) : base(r) {}
    public override double Area()
    {
        return 4 * Math.PI * _radius * _radius;
    }
}