using System;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            char keyChar;
            do
            {
                // Console.ReadKey() получает следующий нажатый пользователем символ или функциональную клавишу. 
                // Нажатая клавиша отображается в окне консоли. 
                ConsoleKeyInfo info = Console.ReadKey();
                // ConsoleKeyInfo описывает нажатую клавишу консоли, включая символ, представленный этой клавишей, 
                // и состояние управляющих клавиш CTRL, SHIFT и ALT.
                key = info.Key; // Возвращает клавишу консоли, представленную текущим объектом ConsoleKeyInfo.
                if (key == ConsoleKey.Escape)
                    break;
                Console.WriteLine(key);
            } while (true);
            Console.Clear();
            do
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                keyChar = info.KeyChar;
                key = info.Key;
                if (key == ConsoleKey.Escape)
                    break;
                Console.WriteLine(keyChar); // Возвращает символ Юникода, представленный текущим объектом ConsoleKeyInfo.
            } while (true);

        }
    }
}