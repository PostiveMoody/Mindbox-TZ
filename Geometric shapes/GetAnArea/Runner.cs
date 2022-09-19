using System;
using Contract;
using Run;

public class Runner 
{
    static void Main(string[] args)
    {
        
        Triangle triangle = new Triangle(3,4,5);

        Execute(triangle);

        Console.WriteLine("Был создана фигура: " + triangle.FigureName);

        if (triangle.RightTriangle)
            Console.WriteLine("Треугольник является прямоугольным");


        Circle circle = new Circle(5);
        Console.WriteLine("Был создана фигура: " + circle.FigureName);

        Console.ReadLine();
    }
    public static void Execute(IShape shape)
    {
        shape.GetArea();
    }
}
