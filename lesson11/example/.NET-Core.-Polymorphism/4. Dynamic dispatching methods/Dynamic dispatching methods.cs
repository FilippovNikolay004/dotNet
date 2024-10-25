using System;


class Figure
{
    protected double x;
    protected double y;
    public void SetDimension(double i, double j)
    {
        x = i;
        y = j;
    }
    public virtual void ShowSquare()
    {
        Console.WriteLine("\nValue is undefined\n");
    }
}

class Triangle : Figure
{
    public override void ShowSquare()
    {
        Console.WriteLine("\nSquare of triangle: {0}", x * 0.5 * y);
    }
}

class Rectangle : Figure
{
    public override void ShowSquare()
    {
        Console.WriteLine("\nSquare of rectangle: {0}", x * y);
    }
}

class Circle : Figure
{
    public override void ShowSquare()
    {
        Console.WriteLine("\nSquare of circle: {0}", 3.14 * x * x);
    }
}

class EntryPoint
{
    static void Print(Figure f)
    {
        f.ShowSquare();
    }
    static void Main()
    {
        Figure f = null;
        Console.WriteLine("1. Square triangle\n2. Square rectangle\n3. Square circle\n");
        Console.WriteLine("Make your choice: ");
        char s = (char)Console.Read();
        switch (s)
        {
            case '1':
                f = new Triangle();
                f.SetDimension(5.5, 10.0);
                break;
            case '2':
                f = new Rectangle();
                f.SetDimension(5.5, 10.0);
                break;
            case '3':
                f = new Circle();
                f.SetDimension(10.0, 0);
                break;
            default:
                Console.WriteLine("Некорректный выбор!");
                return;
        }
        Print(f);
    }
}
