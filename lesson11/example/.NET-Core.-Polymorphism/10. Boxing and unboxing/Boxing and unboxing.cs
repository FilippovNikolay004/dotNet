//Boxing and unboxing

using System;
class BoxingDemo
{
    static int Sqr(object оbj)
    {
        return (int)оbj * (int)оbj;
    }

    public static void Main()
    {
        int x;
        object obj;
        x = 10;
        obj = x; // "Превращаем" х в объект.
        int у = (int)obj; // Обратное "превращение" объекта obj в int-значение.
        Console.WriteLine(у);
        x = Sqr(x);
        Console.WriteLine("Значение x в квадрате равно: " + x);
        string str = 234.ToString();
        Console.WriteLine(str);
    }
}