using System;

abstract class Figure
{
    protected double x;
    protected double y;
    public Figure(double i, double j)
    {
        x = i;
        y = j;
    }
    public abstract void ShowSquare();
    public abstract string ShowFigure { get; }
}


class Triangle : Figure
{
    public override void ShowSquare()
    {
        Console.WriteLine("\nSquare of triangle: {0}", x * 0.5 * y);
    }
    public Triangle(double i, double j)
        : base(i, j)
    {

    }
    public override string ShowFigure
    {
        get { return "triangle"; }
    }
}

class Rectangle : Figure
{
    public override void ShowSquare()
    {
        Console.WriteLine("\nSquare of rectangle: {0}", x * y);
    }
    public Rectangle(double i, double j)
        : base(i, j)
    {

    }
    public override string ShowFigure
    {
        get { return "rectangle"; }
    }
}

class Circle : Figure
{
    public override void ShowSquare()
    {
        Console.WriteLine("\nSquare of circle: {0}", 3.14 * x * x);
    }

    public Circle(double i)
        : base(i, 0)
    {

    }

    public override string ShowFigure
    {
        get { return "circle"; }
    }
}

class EntryPoint
{
    static Random rnd = new Random();
    public static Figure GeneratorOfFigures()
    {
        int n = rnd.Next(3);
        switch (n)
        {
            case 0: return new Triangle(10.5, 6.5);
            case 1: return new Rectangle(10.5, 6.5);
            case 2: return new Circle(10);
            default: return null;
        }
    }

    static void Main()
    {
        Figure[] p = new Figure[20];
        int count_triangle = 0, count_rectangle = 0, count_circle = 0;
        for (int i = 0; i < 20; i++)
        {
            p[i] = GeneratorOfFigures();
            if (p[i] is Rectangle)
                count_rectangle++;
            else if (p[i] is Triangle)
                count_triangle++;
            else if (p[i] is Circle)
                count_circle++;
            Console.WriteLine(p[i].ShowFigure);
        }
        Console.WriteLine("Quantity of triangle: " + count_triangle);
        Console.WriteLine("\nQuantity of rectangle: " + count_rectangle);
        Console.WriteLine("\nQuantity of circle: " + count_circle);
        Console.WriteLine("\n\n");


        count_triangle = 0;
        count_rectangle = 0;
        count_circle = 0;
        for (int i = 0; i < 20; i++)
        {
            p[i] = GeneratorOfFigures();
            Console.WriteLine(p[i].ShowFigure);
            Rectangle r = p[i] as Rectangle;
            if (r != null)
            {
                count_rectangle++;
                continue;
            }

            Triangle t = p[i] as Triangle;
            if (t != null)
            {
                count_triangle++;
                continue;
            }

            Circle c = p[i] as Circle;
            if (c != null)
            {
                count_circle++;
                continue;
            }


        }
        Console.WriteLine("\nQuantity of triangle: " + count_triangle);
        Console.WriteLine("\nQuantity of rectangle: " + count_rectangle);
        Console.WriteLine("\nQuantity of circle: " + count_circle);

    }
}
