// Использование класса object для создания массива обобщенного типа.
using System;

class GenericDemo
{
    public static void Main()
    {
        object[] ga = new object[10];
        // Сохраняем int-значения.
        for (int i = 0; i < 3; i++)
            ga[i] = i;
        // Сохраняем double-значения.
        for (int i = 3; i < 6; i++)
            ga[i] = (double)i / 2;
        // Сохраняем две строки, bool- и char-значения
        ga[6] = "Массив обобщенного типа";
        ga[7] = true;
        ga[8] = 'X';
        ga[9] = "Конец";
        for (int i = 0; i < ga.Length; i++)
            Console.WriteLine("gа[" + i + "] : " + ga[i] + " ");
    }
}

