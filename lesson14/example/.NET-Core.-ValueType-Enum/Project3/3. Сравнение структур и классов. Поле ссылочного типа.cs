﻿
using System;

class TestClass
{
    int[] r;
    public TestClass(int n)
    {
        r = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите {0} элемент массива", i);
            r[i] = int.Parse(Console.ReadLine());
        }
    }

    public int this[int index]
    {
        get { return r[index]; }
        set { r[index] = value; }
    }

    public void Show()
    {
        foreach (int temp in r)
            Console.Write("{0,4}", temp);
    }
}

struct TestStruct
{
    int[] r;
    public TestStruct(int n)
    {
        r = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите {0} элемент массива", i);
            r[i] = int.Parse(Console.ReadLine());
        }
    }

    public int this[int index]
    {
        get { return r[index]; }
        set { r[index] = value; }
    }

    public void Show()
    {
        foreach (int temp in r)
            Console.Write("{0,4}", temp);
    }
}

class MainClass
{
    public static void Main()
    {
        TestClass obj1 = new TestClass(5);
        Console.WriteLine("Печать объекта класса obj1");
        obj1.Show();
        TestClass obj2 = obj1;
        obj2[3] = 100;
        Console.WriteLine("\nПечать объекта класса obj1");
        obj1.Show();
        Console.WriteLine("\n\n");

        TestStruct obj3 = new TestStruct(5);
        Console.WriteLine("Печать объекта структуры obj3");
        obj3.Show();
        TestStruct obj4 = obj3;
        obj4[3] = 100;
        Console.WriteLine("\nПечать объекта структуры obj3");
        obj3.Show();
    }
}

