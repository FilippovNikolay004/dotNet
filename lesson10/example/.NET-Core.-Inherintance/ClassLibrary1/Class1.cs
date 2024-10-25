using System;

namespace ClassLibrary1
{
    public class BaseClass
    {
        private int a = 10;
        protected int b = 20;
        public int c = 30;
        internal protected int d = 40; 
        private protected int e = 80;
        internal void Show()
        {
            Console.WriteLine($"{a}   {b}   {c}   {d}");
        }
    }

    public class DerivedClass : BaseClass
    {
        private int f = 50;
        protected int g = 60;
        public int h = 70;
        internal protected int i = 80;
       
        new public void Show()
        {
            base.Show();
            Console.WriteLine($"{e}   {f}   {g}   {h}   {i}   {b}   {c}   {d}");
        }
    }

    public class A
    {
        public int i;
        public void Print()
        {
            DerivedClass o = new();
            Console.WriteLine(o.i);
        }
    }
}
