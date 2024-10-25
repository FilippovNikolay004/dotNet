// Пример сокрытия имени в связи с наследованием.
using System;
class A
{
    int i;
    public A(int a)
    {
        i = a; 
    }
    public void Show()
    {
        Console.WriteLine("Поле i в базовом классе A: " + i);
    }
}

class B : A
{
    int i;
    public B(int a, int b)
        : base(a)
    {
        i = b; 
    }
    new public void Show()
    {
        base.Show();
        Console.WriteLine("Поле i в производном классе B: " + i);
    }
}

class C : B
{
    int i;
    public C(int a, int b, int c)
        : base(a, b)
    {
        i = c; 
    }
    new public void Show()
    {
        base.Show();
        Console.WriteLine("Поле i в производном классе C: " + i);
    }
}

class MainClass
{
    public static void Main()
    {
        C ob = new C(1, 2, 3);
        ob.Show();
    }
}
