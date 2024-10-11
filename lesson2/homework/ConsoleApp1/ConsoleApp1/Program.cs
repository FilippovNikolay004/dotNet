using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static int GetSum(int a, int b) {
            return a + b;
        }
        static void Practice() {
            // Task 1
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
            Console.WriteLine("");


            // Task 2
            int max = 0;
            int min = 0;
            int sum = 0;
            int sumWorks = 1;

            for (int i = 1; i <= 5; i++) {
                Console.Write(i + ": ");
                int number = int.Parse(Console.ReadLine());
                if (i == 1) { max = min = number; }

                sum += number;
                sumWorks *= number;

                if (number > max) { max = number; }
                if (number < min) { min = number; }
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("SumWorks: " + sumWorks);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("");


            // task 3
            int enterNumber = 0;
            do {
                Console.Write("Введите 6-и значное число: ");
                enterNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели: " + enterNumber);

                if (enterNumber.ToString().Length < 6) {
                    Console.WriteLine("Вы ввели не 6-ти значное число!");
                }
                else {
                    string reversed = string.Empty;
                    for (int i = enterNumber.ToString().Length - 1; i >= 0; i--) {
                        reversed += enterNumber.ToString()[i];
                    }

                    Console.WriteLine("Реверс: " + reversed);
                }
            } while (enterNumber.ToString().Length < 6);
            Console.WriteLine("");


            // task 4


            for (int c = 0; c < 3; c++) {
                Console.Write("Введите 1-е знач.: ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Введите 2-е знач.: ");
                int end = int.Parse(Console.ReadLine());

                int sumTmp = 0;

                sum = 0;

                for (int i = 0, j = 1, k = 0; ; ) {
                    if (start <= 1 && start >= 0 && sumTmp == 0) {
                        if (start == 0)
                            Console.WriteLine(++k + "-e число: " + i);
                        Console.WriteLine(++k + "-e число: " + j);
                    }

                    sumTmp = sum = i + j;
                    if (sumTmp > end) { break; }
                    else if (sumTmp >= start) {
                        Console.Write(++k + "-e число: " + i + " + " + j + " = ");
                        Console.WriteLine(sum);
                    }

                    sumTmp = i = j + sum;
                    if (sumTmp > end) { break; }
                    else if (sumTmp >= start) {
                        Console.Write(++k + "-e число: " + j + " + " + sum + " = ");
                        Console.WriteLine(i);
                    }
                
                    sumTmp = j = sum + i;
                    if (sumTmp > end) { break; }
                    else if (sumTmp >= start) {
                        Console.Write(++k + "-e число: " + sum + " + " + i + " = ");
                        Console.WriteLine(j);
                    } 
                }

                Console.WriteLine("");
            }

            // task 5
            int a = 0;
            int b = 0;
            bool isNext = false;
            do {
                Console.Write("Введите A = ");
                a = int.Parse(Console.ReadLine());

                isNext = a < 0;

                if (isNext) { Console.WriteLine("Введите число больше 0!"); }
            } while (isNext);
            do {
                Console.Write("Введите B = ");
                b = int.Parse(Console.ReadLine());

                isNext = b < 0;

                if (isNext) { Console.WriteLine("Введите число больше 0!"); }
            } while (isNext);

            for (int i = a; a <= b; a++) {
                for (int j = 0; j < a; j++) {
                    Console.Write(a);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            // task 6
            Console.Write("Введите длину линии: ");
            int lineLength = int.Parse(Console.ReadLine());

            Console.Write("Введите символ линии: ");
            char symbol = char.Parse(Console.ReadLine());

            int lineDirection = 0;
            do {
                Console.Write("Направление линии\n(1 - гориз. 2 - верт.): ");
                lineDirection = int.Parse(Console.ReadLine());

                isNext = lineDirection > 2 && lineDirection < 1 ;

                if (isNext) { Console.WriteLine("Некорректный ввод!"); }
            } while (isNext);
            Console.WriteLine("");

            for (int i = 0; i < lineLength; i++) {
                if (lineDirection == 1) { Console.Write(symbol); }
                else { Console.WriteLine(symbol); }
            }
            Console.WriteLine("");
        }
        static void Main(string[] args) {
            #region Показать тектс!
            // Console.WriteLine('Hello world');
            #endregion

            //int a = int.Parse(str);
            //int a = Convert.ToInt32(str);
            //int a = int.Parse(Console.ReadLine());
            //a += 10;
            //Console.WriteLine(a);

            //double d = 19.4;

            //double Price = double.Parse(Console.ReadLine());

            Practice();
        }
    }
}
