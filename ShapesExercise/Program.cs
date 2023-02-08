
using ShapesExercise;
using System.Collections;

Shape c1 = new Circle("Circle", "Green", 1.1);
//Console.WriteLine(c1.GetInfo());
Shape c2 = new Rectangle("Rectangle", "Red", 1.5, 200);
//Console.WriteLine(c2.GetInfo());
Shape c3 = new Triangle("Triangle", "Purple", 2.0, 150);
//Console.WriteLine(c3.GetInfo());

List<Shape> shapes = new List<Shape>
{
    c1,
    c2,
    c3
};

foreach (Shape s in shapes)
{
    if (s is Circle)
    {
        Console.WriteLine(s.GetInfo());
    }
    Console.WriteLine(s.GetInfo());
    Console.WriteLine();
}

shapes.Sort();
Console.WriteLine("**********************LAJITELTU LISTA***********************'");
foreach (Shape x in shapes)
{
    Console.WriteLine(x.GetInfo());
    Console.WriteLine();
}

