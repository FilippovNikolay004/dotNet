
using System;

struct Book
{
    public string author = "Andrew Troelsen";
    public string title = "Pro C# 10 with .NET 6";
    public int copyright = 2020;
    public Book(string a, string t, int c)
    {
        author = a;
        title = t;
        copyright = c;
    }
    public Book()
    {
        author = "Jeffrey Richter";
        title = "CLR via C#";
        copyright = 2013;
    }
}

class StructDemo
{
    public static void Main()
    {
        Book book1 = new Book("Herb Schildt", "C# A Beginner's Guide", 2001); // Вызов явно заданного конструктора.
        Console.WriteLine(book1.title + ", автор " + book1.author + ", (с) " + book1.copyright);
        Book book2 = new Book(); // Вызов конструктора по умолчанию.
        Console.WriteLine(book2.title + ", автор " + book2.author + ", (c) " + book2.copyright);
        Console.WriteLine();
        Book book3; // Создание объекта без вызова  конструктора.   
        //Console.WriteLine(bоок3.title); // Ошибка: сначала  необходима инициализация.
        book3.title = "Программирование на платформе Microsoft .NET Framework";
        book3.author = "Рихтер Дж.";
        book3.copyright = 2003;
        Console.WriteLine(book3.title + ", автор " + book3.author + ", (c) " + book3.copyright);
    }
}
