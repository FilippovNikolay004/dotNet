
using System;

class TestClass
{
    int r = 10;
    public TestClass(int n)
    {
        r = n;       
    }
    public int PropR
    {
        get { return r; }
        set { r = value; }
    }
}

struct TestStruct
{
    int r = 10; 
    public TestStruct(int n)
    {
        r = n;
        
    }
    public int PropR
    {
        get { return r; }
        set { r = value; }
    }
}

class MainClass
{
    public static void Main()
    {
        TestClass obj1 = new TestClass(5);
        Console.WriteLine("Печать объекта класса obj1");
        Console.WriteLine(obj1.PropR);
        TestClass obj2 = obj1;
        obj2.PropR = 100;
        Console.WriteLine("\nПечать объекта класса obj1 после присваивания");
        Console.WriteLine(obj1.PropR);
        Console.WriteLine("\n");

        TestStruct obj3 = new TestStruct(5);
        Console.WriteLine("Печать объекта структуры obj3");
        Console.WriteLine(obj3.PropR);
        TestStruct obj4 = obj3;
        obj4.PropR = 100;
        Console.WriteLine("\nПечать объекта структуры obj3 после присваивания");
        Console.WriteLine(obj3.PropR);
    }
}

