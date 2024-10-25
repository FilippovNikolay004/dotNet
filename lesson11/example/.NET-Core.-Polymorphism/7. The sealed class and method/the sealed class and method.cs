
using System;
sealed class A
{
    protected int i, j; // в терминальном классе нет смысла создавать защищённые поля
    public A(int a, int b)
    {
        i = a;
        j = b;
    }
    public void Show()
    {
        Console.WriteLine(i + " " + j);

    }
}

class B /*: A*/  // нельзя наследоваться от терминального класса
{
    protected int k;
    public B(int k)
    {
        this.k = k;
    }
    public virtual void Show()
    {
        Console.WriteLine(k);
    }
}

class C : B
{
    protected int m;
    public C(int k, int m)
        : base(k)
    {
        this.m = m;
    }
    public override sealed void Show()
    {
        base.Show();
        Console.WriteLine(m);
    }
}

class D : C
{
    protected int n;
    public D(int k, int m, int n)
        : base(k, m)
    {
        this.n = n;
    }
    /*
    public override void Show() // нельзя переопределять sealed-метод
    {
        base.Show();
        Console.WriteLine(n);
    }
    */
}

class MainClass
{
    public static void Main()
    {
        B ob = new B(10);
        ob.Show();
        ob = new C(10, 20);
        ob.Show();
    }
}
