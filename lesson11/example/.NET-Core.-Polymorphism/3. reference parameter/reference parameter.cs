using System;

class TwoDShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public TwoDShape()
        : this(0, 0)
    {
    }

    public TwoDShape(double w, double h)
    {
        Width = w;
        Height = h;
    }

    public TwoDShape(double x)
        : this(x, x)
    {

    }

    public TwoDShape(TwoDShape ob)
    {
        Width = ob.Width;
        Height = ob.Height;
    }


    public void ShowDim()
    {
        Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
    }
}

class Triangle : TwoDShape
{
    public string Style { get; set; }

    public Triangle()
        : this(null, 0, 0)
    {

    }

    public Triangle(string s, double w, double h)
        : base(w, h)
    {
        Style = s;
    }

    public Triangle(double x)
        : base(x)
    {
        Style = "равнобедренный";
    }

    public Triangle(Triangle ob)
        : base(ob)
    {
        Style = ob.Style;
    }

    public double Area()
    {
        return Width * Height / 2;
    }
    public void ShowStyle()
    {
        Console.WriteLine("Треугольник " + Style);
    }
}


class MainClass
{
    public static void Main()
    {
        Triangle t1 = new Triangle("прямоугольный", 8.0, 12.0);
        Triangle t2 = new Triangle(t1);
        Console.WriteLine("Информация о tl: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Площадь равна " + t1.Area());
        Console.WriteLine();
        Console.WriteLine("Информация о t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Площадь равна " + t2.Area());
    }
}