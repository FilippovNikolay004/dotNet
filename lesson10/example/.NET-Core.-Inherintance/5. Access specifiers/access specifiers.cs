using System;
using ClassLibrary1;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj1 = new DerivedClass();
            obj1.c = 111;
            obj1.h = 222;
            obj1.Show();
            Derived2 obj2 = new Derived2();
            obj2.Show();
            obj2.l = 100;
            Console.WriteLine("{0}   {1}   {2}   {3}", obj2.c, obj2.h, obj2.l, obj2.m);
        }
    }

    public class Derived2 : DerivedClass
    {
        private int j = 50;
        protected int k = 60;
        public int l = 70;
        internal protected int m = 80;
        new internal void Show()
        {           
            base.Show();
            Console.WriteLine($"{b}   {c}   {d}   {g}   {h}   {i}   {j}   {k}   {l}   {m}");
        }
    }
}
