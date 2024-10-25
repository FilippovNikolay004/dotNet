class X
{
    int a;
    public X(int i) { a = i; }
}

class Y
{
    int a;
    public Y(int i) { a = i; }
}

class IncompatibleRef
{
    public static void Main()
    {
        X x = new X(10);
        X x2;
        Y у = new Y(5);
        x2 = x; // OK, обе переменные имеют одинаковый тип.
        //х2 = у; // Ошибка, здесь переменные разного типа.
    }
}