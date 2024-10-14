using CSharp.Classes;
using System;

Console.WriteLine("Конструктор по умолчанию");
Car myCar = new();
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}

Console.WriteLine("\n\nКонструктор с параметрами");
myCar = new Car("Рубенс Барикелло");
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}
