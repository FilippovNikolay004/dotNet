#region Задание 1
// TASK:
//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.
//Если число кратно 3 (делится на 3 без остатка) нужно вывести слово Fizz.
//Если число кратно 5 нужно вывести слово Buzz.
//Если число кратно 3 и 5 нужно вывести Fizz Buzz.
//Если число не кратно не 3 и 5 нужно вывести само число.
//Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.

// СODE:
using System.Globalization;

int start = 0;
int end = 0;

bool isNext = true;

do {
    Console.Write("Введите начало диапазона: ");
    start = int.Parse(Console.ReadLine());

    isNext = !(start > 0 && start <= 99);
    if (isNext) { Console.WriteLine("Вы ввели неверный диапазон!\n"); }
} while (isNext);

do {
    Console.Write("Введите конец диапазона: ");
    end = int.Parse(Console.ReadLine());

    isNext = !((end > start) && (end <= 100));
    if (isNext) { Console.WriteLine("Вы ввели неверный диапазон!\n"); }
} while (isNext);

for (int i = start; i <= end; i++) {
    if ((i % 3) == 0 && (i % 5) == 0) { Console.WriteLine("Fizz Buzz"); } 
    else if ((i % 5) == 0) { Console.WriteLine("Buzz"); } 
    else if ((i % 3) == 0) { Console.WriteLine("Fizz"); }
    else { Console.WriteLine(i); }
}
Console.WriteLine("");
#endregion

#region Задание 2
// TASK:
//Пользователь вводит с клавиатуры два числа.
//Первое число — это значение, второе число процент, который необходимо посчитать.
//Например, мы ввели с клавиатуры 90 и 10.
//Требуется вывести на экран 10 процентов от 90.
//Результат: 9.

// СODE:
int value = 0, percent = 0;

do {
    Console.Write("Введите значение: ");
    value = int.Parse(Console.ReadLine());

    isNext = !(value > 0);
    if (isNext) { Console.WriteLine("Значение должно быть больше 0!\n"); }
} while (isNext);

do {
    Console.Write("Введите прцоент: ");
    percent = int.Parse(Console.ReadLine());

    isNext = !(percent >= 0 && percent <= 100);
    if (isNext) { Console.WriteLine("Вы ввели неверный диапазон скидки!\n"); }
} while (isNext);

float result = ((float)percent / 100) * (float)value;
Console.WriteLine(percent + "% от " + value + " = " + result);
Console.WriteLine("");
#endregion

#region Задание 3
// TASK:
//Пользователь вводит с клавиатуры четыре цифры.
//Необходимо создать число, содержащее эти цифры.
//Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.

// СODE:
int a = 0, b = 0, c = 0, d = 0;

do {
    Console.Write("Введите 1-е значение: ");
    a = int.Parse(Console.ReadLine());

    isNext = !(a >= 0);
    if (isNext) { Console.WriteLine("Число должно быть больше 0!"); }
} while (isNext);

do {
    Console.Write("Введите 2-е значение: ");
    b = int.Parse(Console.ReadLine());

    isNext = !(b >= 0);
    if (isNext) { Console.WriteLine("Число должно быть больше 0!"); }
} while (isNext);

do {
    Console.Write("Введите 3-е значение: ");
    c = int.Parse(Console.ReadLine());

    isNext = !(c >= 0);
    if (isNext) { Console.WriteLine("Число должно быть больше 0!"); }
} while (isNext);

do {
    Console.Write("Введите 4-е значение: ");
    d = int.Parse(Console.ReadLine());

    isNext = !(d >= 0);
    if (isNext) { Console.WriteLine("Число должно быть больше 0!"); }
} while (isNext);

result = int.Parse(a.ToString() + b.ToString() + c.ToString() + d.ToString());
Console.WriteLine("Вы ввели: " + a + ", " + b + ", " + c + ", " + d + "\nРезультат: " + result);
Console.WriteLine("");
#endregion

#region Задание 4
// TASK:
//Пользователь вводит шестизначное число.
//После чего пользователь вводит номера разрядов для обмена цифр.
//Например, если пользователь ввёл один и шесть — это значит,
//что надо обменять местами первую и шестую цифры.
//Число 723895 должно превратиться в 523897.
//Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.

// СODE:
string valueOfString = string.Empty;

do {
    Console.Write("Введите 6-ти значное число: ");
    valueOfString = Console.ReadLine();

    isNext = !(valueOfString.Length >= 6);
    if (isNext) { Console.WriteLine("Число должно быть не меньше 6-ти значное!\n"); }
} while (isNext);

do {
    Console.Write("Введите 1-е число: ");
    a = int.Parse(Console.ReadLine());

    isNext = !(a <= 6);

    if (isNext) { Console.WriteLine("Вы ввели число, выходящее за диапозон!"); } 
    else { a--; }
} while (isNext);

do {
    Console.Write("Введите 2-е число: ");
    b = int.Parse(Console.ReadLine());

    isNext = !(b <= 6 && b != a);

    if (isNext) { Console.WriteLine("Вы ввели число, выходящее за диапозон или такое же число!"); } 
    else { b--; }
} while (isNext);

string resultOfString = string.Empty;
for (int i = 0; i < valueOfString.Length; i++) {
    if (i == a) { resultOfString += valueOfString[b]; } 
    else if (i == b) { resultOfString += valueOfString[a]; } 
    else { resultOfString += valueOfString[i]; }
}

Console.WriteLine("Введённое число: " + valueOfString);
Console.WriteLine("Результат: " + resultOfString);
Console.WriteLine("");
#endregion

#region Задание 5
// TASK:
//Пользователь вводит с клавиатуры дату.
//Приложение должно отобразить название сезона и дня недели.
//Например, если введено 22.12.2021, приложение должно
//отобразить Winter Wednesday.

// СODE:
string[] weeks = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

do {
    Console.Write("Введите дату: ");
    valueOfString = Console.ReadLine();

    isNext = !(valueOfString.Length == 10);

    if (isNext) { Console.WriteLine("Вы ввели неверный формат\nФормат: дд.мм.гггг"); } 
    else {
        int countNumber = 0;

        for (int i = 0; i < valueOfString.Length; i++) {
            if (valueOfString[i] >= '0' && valueOfString[i] <= '9') { countNumber++; }
        }

        isNext = !(countNumber == 8);

        if (isNext) { Console.WriteLine("Вы ввели неверный формат\nФормат: дд.мм.гггг"); }
    }
} while (isNext);

string tempOfString = string.Empty;
int tempNumber = 0;
resultOfString = "\0";

for (int i = 0; i < valueOfString.Length; i++) {
    if (valueOfString[i] != '.') {
        tempOfString += valueOfString[i];

        if (i == 1) {
            tempNumber = int.Parse(tempOfString);
            Console.WriteLine("Day: " + tempNumber);

            for (int j = 1, k = 0; j <= 30; j++, k++) {
                if (k > 6) { k = 0; }
                if (j == tempNumber) { resultOfString += weeks[k] + " "; }
            }

            tempOfString = "";
        } else if (i == 4) {
            tempNumber = int.Parse(tempOfString);
            Console.WriteLine("Month: " + tempNumber);

            if ((tempNumber >= 12 && tempNumber <= 12) || (tempNumber >= 1 && tempNumber <= 2)) {
                resultOfString += "Winter";
            } else if (tempNumber >= 3 && tempNumber <= 5) {
                resultOfString += "Spring";
            } else if (tempNumber >= 6 && tempNumber <= 8) {
                resultOfString += "Summer";
            } else if (tempNumber >= 9 && tempNumber <= 11) {
                resultOfString += "Autumn";
            }
        }
    }
}

Console.WriteLine(resultOfString);
Console.WriteLine("");
#endregion

#region Задание 6
// TASK:
//Пользователь вводит с клавиатуры показания температуры.
//В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот.

// СODE:
int choiseUser = 0;

do {
    Console.Write("1. Из Фаренгейта в Цельсий\n2. Из Цельсий в Фаренгейт\nВвод: ");
    choiseUser = int.Parse(Console.ReadLine());

    isNext = !(choiseUser == 1 || choiseUser == 2);
    if (isNext) { Console.WriteLine("Вы ввели неверное значение!"); }
} while (isNext);

Console.Write("Введите t.: ");
float temperature = float.Parse(Console.ReadLine());

if (choiseUser == 1) { temperature = (float)((5.0 / 9.0) * (temperature - 32.0)); } 
else { temperature = (float)((9.0 / 5.0) * temperature + 32.0); }

Console.WriteLine("Результат: " + temperature + (choiseUser == 1 ? "C" : "F"));
Console.WriteLine("");
#endregion

#region Задание 7
// TASK:
//Пользователь вводит с клавиатуры два числа.
//Нужно показать все четные числа в указанном диапазоне.
//Если границы диапазона указаны неправильно требуется произвести нормализацию границ.
//Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.

// СODE:
Console.Write("Введите 1-е число: ");
a = int.Parse(Console.ReadLine());

Console.Write("Введите 2-е число: ");
b = int.Parse(Console.ReadLine());

tempNumber = 0;
if (a > b) {
    tempNumber = a;
    a = b;
    b = tempNumber;
}

Console.WriteLine("Чётные числа:");
for (int i = a; i <= b; i++) {
    if ((i % 2) == 0) { Console.Write(i + (i != b ? ", " : "")); }
}

Console.WriteLine("");
#endregion