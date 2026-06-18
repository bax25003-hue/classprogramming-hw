class Cylinder : Circle
{
    // Attributes
    private double _height;
    
    // Behaviors
    public Cylinder(double r, double h) : base(r)
    {
        _height = h;
    }
    public override double Area()
    {
        return 2.0 * (Math.PI * _radius * _radius) + 
            Math.PI * _radius * _height;
    }
}