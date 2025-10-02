// See https://aka.ms/new-console-template for more information
using Polymorphism;

public class Program
{
    public static void Main(string[] args)
    {
        var shapes = new List<Shape>{ new Circle(),new Rectangle()
    };
        var canvas = new Canvas();
        canvas.DrawShape(shapes);
    }
}