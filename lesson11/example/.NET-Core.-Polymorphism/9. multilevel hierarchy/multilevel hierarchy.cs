using System;

class A
{
    public virtual void Print()
    {
        Console.WriteLine("Класс A");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("Класс B");
    }
}

class C : B
{
    public override void Print()
    {
        Console.WriteLine("Класс C");
    }
}

class D : C
{
    public override void Print()
    {
        Console.WriteLine("Класс D");
    }
}


class EntryPoint
{
    static Random rnd = new Random();
    public static A Generator()
    {
        int n = rnd.Next(4);
        switch (n)
        {
            case 0: return new A();
            case 1: return new B();
            case 2: return new C();
            case 3: return new D();
            default: return null;
        }
    }

    static void Main()
    {
        A[] p = new A[20];
        int a = 0, b = 0, c = 0, d = 0;
        for (int i = 0; i < 20; i++)
        {
            p[i] = Generator();
            if (p[i] is D)
                d++;
            else if (p[i] is C)
                c++;
            else if (p[i] is B)
                b++;
            else 
                a++;
            p[i].Print();
        }
        Console.WriteLine("Quantity of A: " + a);
        Console.WriteLine("\nQuantity of B: " + b);
        Console.WriteLine("\nQuantity of C: " + c);
        Console.WriteLine("\nQuantity of D: " + d);
        Console.WriteLine("\n\n");

        a = 0;
        b = 0;
        c = 0;
        d = 0;
        for (int i = 0; i < 20; i++)
        {
            p[i] = Generator();
            p[i].Print();
            D objD = p[i] as D;
            if (objD != null)
            {
                d++;
                continue;
            }

            C objC = p[i] as C;
            if (objC != null)
            {
                c++;
                continue;
            }

            B objB = p[i] as B;
            if (objB != null)
            {
                b++;
                continue;
            }

            a++;
            
        }
        Console.WriteLine("Quantity of A: " + a);
        Console.WriteLine("\nQuantity of B: " + b);
        Console.WriteLine("\nQuantity of C: " + c);
        Console.WriteLine("\nQuantity of D: " + d);
        Console.WriteLine("\n\n");
    }
}
