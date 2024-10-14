using System;

namespace CSharp.Params
{
    class ParamsDemo
    {
        public static int MinVal(params int[] nums)
        {
            int m;
            if (nums.Length == 0)
            {
                Console.WriteLine("Ошибка: нет аргументов.");
                return 0;
            }
            m = nums[0];
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] < m) m = nums[i];
            return m;

        }
        public static void ShowArgs(string msg, params int[] nums)
        {
            Console.Write(msg + ": ");
            foreach (int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        public static void Main()
        {
            int min;
            int a = 10, b = 20;
            // Вызываем метод с двумя значениями
            min = MinVal(a, b);
            Console.WriteLine("Минимум равен " + min);
            // Вызываем метод с тремя значениями
            min = MinVal(a, b, -1);
            Console.WriteLine("Минимум равен " + min);
            // Вызываем метод с пятью значениями
            min = MinVal(18, 23, 3, 14, 'A');
            Console.WriteLine("Минимум равен " + min);
            // Вызываем метод с int-массивом.
            int[] args = { 45, 67, 34, 9, 112, 8 };
            min = MinVal(args);
            Console.WriteLine("Минимум равен " + min);

            // Использование обычного параметра вместе с params-параметром
            ShowArgs("Вот несколько целых чисел", 1, 2, 3, 4, 5);
            ShowArgs("А вот еще два числа", 17, 20);
        }
    }
}
