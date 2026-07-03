using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        TestClass nullTest = new TestClass(false);

        bool? testVar = nullTest.NullTestMethod(4);
        Console.WriteLine(testVar);
        try
        {
            Console.WriteLine(testVar);
            Console.WriteLine(testVar.GetType());
        }
        catch (System.NullReferenceException nullEx)
        {
            Console.WriteLine(nullEx);
            Console.WriteLine("A variable type is null!");
        }

    }
}