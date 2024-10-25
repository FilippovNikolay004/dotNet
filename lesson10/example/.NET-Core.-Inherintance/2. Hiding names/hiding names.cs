// Использование ссылки base для доступа к скрытому имени.
using System;
class A
{
    public int MyProperty { get; set; }
}

class В : A
{
    new public int MyProperty { get; set; } // Это свойство MyProperty скрывает MyProperty класса А.
    public В(int a, int b)
    {
        base.MyProperty = a; // Так можно обратиться к MyProperty класса А.
        MyProperty = b; // Свойство MyProperty в классе В.
    }
    public void Show()
    {
        Console.WriteLine("MyProperty в базовом классе: " + base.MyProperty);
        Console.WriteLine("MyProperty в производном классе: " + MyProperty);
    }
}

class MainClass
{
    public static void Main()
    {
        В ob = new В(1, 2);
        ob.Show();
        ob.MyProperty = 100;
        ob.Show();
    }
}