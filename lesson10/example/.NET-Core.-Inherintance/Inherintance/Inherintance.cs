using System;
class TwoDShape
{
    public TwoDShape()
        : this(0, 0)
    {
    }

    public TwoDShape(double w, double h)
    {
        Console.WriteLine("Конструктор класса TwoDShape");
        Width = w;
        Height = h;
    }

    public TwoDShape(double x)
        : this(x, x)
    {

    }

    public double Width { get; set; }
    public double Height { get; set; }

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
        Console.WriteLine("Конструктор класса Triangle");
        Style = s;
    }


    public Triangle(double x)
        : base(x)
    {
        Style = "равнобедренный";
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


class ColorTriangle : Triangle
{
    public string Color { get; set; }

    public ColorTriangle(string c, string s, double w, double h)
       : base(s, w, h)
    {
        Console.WriteLine("Конструктор класса ColorTriangle");
        Color = c;
    }

    public ColorTriangle() : this(null, null, 0, 0)
    {

    }

    public void ShowColor()
    {
        Console.WriteLine("Цвет " + Color);
    }
}

class MainClass
{
    public static void Main()
    {
        ColorTriangle tl = new ("синий", "прямоугольный", 8.0, 12.0);
        ColorTriangle t2 = new ColorTriangle() { Width = 2.0, Height = 2.0, 
                            Color = "красный", Style = "равнобедренный" };
        Console.WriteLine("Информация о tl: ");
        tl.ShowStyle();
        tl.ShowDim();
        tl.ShowColor();
        Console.WriteLine("Площадь равна " + tl.Area());
        Console.WriteLine();
        Console.WriteLine("Информация о t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        t2.ShowColor();
        Console.WriteLine("Площадь равна " + t2.Area());
    }
}