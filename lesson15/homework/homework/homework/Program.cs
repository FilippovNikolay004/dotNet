using homework;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program {
    delegate int[] MyDelegate(int[] a);
    delegate void MyDelegate1();
    delegate double MyDelegateFigureArea(double width, double height);

    class MainClass {
        #region Задание1
        // Метод для получения всех четных чисел в массиве
        public static int[] GetEvenNumbers(int[] a) {
            int[] tempResult = new int[a.Length];
            int count = 0;

            for (int i = 0, j = 0; i < a.Length; i++) {
                if ((a[i] % 2) == 0) { tempResult[j++] = a[i]; count++; };
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++) { result[i] = tempResult[i]; }

            return result;
        }

        // Метод для получения всех нечетных чисел в массиве
        public static int[] GetOddNumbers(int[] a) {
            int[] tempResult = new int[a.Length];
            int count = 0;

            for (int i = 0, j = 0; i < a.Length; i++) {
                if ((a[i] % 2) != 0) { tempResult[j++] = a[i]; count++; };
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++) { result[i] = tempResult[i]; }

            return result;
        }

        // Метод для получения всех простых чисел в массиве
        public static int[] GetPrimeNumbers(int[] a) {
            int[] tempResult = new int[a.Length];
            int count = 0;

            for (int i = 0; i < a.Length; i++) {
                if (IsPrime(a[i])) { tempResult[count++] = a[i]; }
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++) { result[i] = tempResult[i]; }

            return result;
        }
        private static bool IsPrime(int number) {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i * i <= number; i++) {
                if (number % i == 0) { return false; }
            }

            return true;
        }

        // Метод для получения всех чисел Фибоначчи в массиве
        public static int[] GetFibonacciNumbers(int[] a) {
            int[] tempResult = new int[a.Length];
            int count = 0;

            for (int i = 0; i < a.Length; i++) {
                if (IsFibonacci(a[i])) {
                    tempResult[count++] = a[i];
                }
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++) {
                result[i] = tempResult[i];
            }

            return result;
        }

        private static bool IsFibonacci(int number) {
            if (number < 0) return false;

            // Проверка: число является Фибоначчи, если   или 5*n^2 - 4 — это полный квадрат
            int x1 = 5 * number * number + 4;
            int x2 = 5 * number * number - 4;

            return IsPerfectSquare(x1) || IsPerfectSquare(x2);
        }

        private static bool IsPerfectSquare(int num) {
            int s = (int)Math.Sqrt(num);
            return s * s == num;
        }


        public static void Print(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        }
        #endregion

        #region Задание2
        // Метод для отображения текущего времени
        public static void DisplayCurrentTime() {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToLongTimeString());
        }

        // Метод для отображения текущей даты
        public static void DisplayCurrentDate() {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToShortDateString());
        }

        // Метод для отображения текущего дня недели
        public static void DisplayCurrentDayOfWeek() {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek);
        }

        // Метод для подсчёта площади треугольника
        public static double CalculateTriangleArea(double baseLength, double height) { return (baseLength * height) / 2; }

        // Метод для подсчёта площади прямоугольника
        public static double CalculateRectangleArea(double width, double height) { return width * height; }
        #endregion

        #region Задание3
        
        #endregion
        static void Main() {
            MyDelegate[] dg = { GetEvenNumbers, GetOddNumbers, GetPrimeNumbers, GetFibonacciNumbers };
            MyDelegate1[] dg1 = { DisplayCurrentDate, DisplayCurrentDayOfWeek };
            Action action = new Action(DisplayCurrentTime);
            MyDelegateFigureArea[] dgFigureArea = { CalculateTriangleArea, CalculateRectangleArea };
            Random rnd = new Random();

            int[] arr = new int[15];

            for (int i = 0; i < arr.Length; i++) { arr[i] = rnd.Next(1, 50); }
            
            Console.WriteLine("Task 1:");
            for (int i = 0; i < dg.Length; i++) { Print(dg[i](arr)); Console.WriteLine(""); }

            Console.WriteLine("\nTask 2:");
            action();
            for (int i = 0; i < dg1.Length; i++) { dg1[i](); }
            Console.WriteLine(dgFigureArea[0](6, 4));
            Console.WriteLine(dgFigureArea[1](6, 4));


            // TASK 3
            Console.WriteLine("\nTask 3:");
            CreditCard creditCard = new CreditCard("4149567823645978", "Иван", "Иванов", 1234, 50000, 10000);
            creditCard.Print();

            creditCard.EnterPin();
            creditCard.ChangePin();
            creditCard.EnterPin();
        }
    }
}