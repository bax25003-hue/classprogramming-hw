using System.Runtime.InteropServices;

namespace RoundShapes;

class Program
{
    static void Main(string[] args)
    {
        List<RoundShape> myShapes = new List<RoundShape> ();

        // myShapes.Add( new RoundShape() ); -- Cannot instantiate an abstract class
        myShapes.Add( new Circle(1.0) );
        myShapes.Add( new Cylinder(1.0, 0.1) );
        myShapes.Add( new Sphere(7.0) );

        foreach (RoundShape shape in myShapes)
        {
            Console.WriteLine($"{shape.Area}");
        }        
    }
}
