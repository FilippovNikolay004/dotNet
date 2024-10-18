using System;
using MyNamespaceA.MyNamespaceB;
using static System.Console;
using Alias = MyNamespaceA.MyNamespaceB;
using AliasABTest = MyNamespaceA.MyNamespaceB.Test;

namespace MyNamespaceA
{
    namespace MyNamespaceB
    {
        class Test
        {
            public static void SomeMethod()
            {
                System.Console.WriteLine("Test");
                Console.WriteLine("Test");
                WriteLine("Test");
            }
        }
    }
}

namespace C
{
    class MainClass
    {
        static void Main()
        {
            MyNamespaceA.MyNamespaceB.Test.SomeMethod();
            Test.SomeMethod(); 
            Alias.Test.SomeMethod();
            AliasABTest.SomeMethod();
        }
    }
}

