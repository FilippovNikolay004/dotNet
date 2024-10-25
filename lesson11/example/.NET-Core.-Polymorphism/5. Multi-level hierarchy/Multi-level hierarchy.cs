// Демонстрация порядка выполнения конструкторов.
using System;

class A
{
    public A()
    {
        Console.WriteLine("Создание класса А.");
    }
    public virtual void Show()
    {
        Console.WriteLine("Класс A");
    }
}

class B : A
{
    public B()
    {
        Console.WriteLine("Создание класса В.");
    }
    public override void Show()
    {
        Console.WriteLine("Класс B");
    }
}

class C : B
{
    public C()
    {
        Console.WriteLine("Создание класса С.");
    }
    public override void Show()
    {
        Console.WriteLine("Класс C");
    }
}

class OrderOfConstruction
{
    public static void Main()
    {
        A refer;
        A a = new A();
        B b = new B();
        C c = new C();
        refer = a;
        refer.Show();
        refer = b;
        refer.Show();
        refer = c;
        refer.Show();
    }
}