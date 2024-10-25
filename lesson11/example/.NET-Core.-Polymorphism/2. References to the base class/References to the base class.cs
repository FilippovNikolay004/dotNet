// Ссылка на базовый класс может указывать на
// объект производного класса

using System;

class X
{
    public int MyPropertyX { get; set; }
    public X(int i)
    {
        MyPropertyX = i;
    }
}

class Y : X
{
    public int MyPropertyY { get; set; }
    public Y(int i, int j)
        : base(j)
    {
        MyPropertyY = i;
    }
}

class BaseRef
{
    public static void Main()
    {
        X x = new X(10);
        X x2;
        Y у = new Y(5, 6);
        x2 = x; // OK, обе переменные имеют одинаковый тип.
        Console.WriteLine("x2.MyPropertyX: " + x2.MyPropertyX);
        x2 = у; // Все равно ok, поскольку класс Y  выведен из класса X.
        Console.WriteLine("х2.MyPropertyX: " + x2.MyPropertyX);
        // Х-ссылки "знают" только о членах класса X.
        x2.MyPropertyX = 19; // ОК
        // x2.MyPropertyY = 27; // Ошибка, в классе X нет члена MyPropertyY.
    }
}