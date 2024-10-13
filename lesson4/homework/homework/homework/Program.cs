#region Задание 3
//TASK:
//Пользователь вводит строку с клавиатуры.
//Необходимо зашифровать данную строку используя шифр Цезаря.
#endregion


#region Задание 5
//TASK:
//Пользователь с клавиатуры вводит в строку арифметическое выражение.
//Приложение должно посчитать его результат.
//Необходимо поддерживать только две операции: + и –.


// CODE:
static int Sum(int a, int b) { return a + b; }
static int Deff(int a, int b) { return a - b; }


string expression = string.Empty;

do {
    Console.Write("Enter exp: ");
    expression = Console.ReadLine();

    if (expression == null) {
        Console.WriteLine("Вы ввели пустую строку!");
    }
    Console.WriteLine("");
} while (expression == null);

// Очистка от лишних пробелов
expression = expression.Replace(" ", "");
Console.WriteLine(expression);

// Добавляем символы для разделения на элементы
expression = expression.Replace("+", "_+_");
expression = expression.Replace("-", "_-_");

// Разбиваем строку на элемены массива
string[] arrayOfExpression = expression.Split(new Char[] {'_'}, StringSplitOptions.RemoveEmptyEntries);

//1-1-2-3+10+1

int sum = 0;
for (int i = 1; i < arrayOfExpression.Length; i++) {
    if (arrayOfExpression[i] == "+") {
        if (i == 1) {
            sum += Sum(int.Parse(arrayOfExpression[i - 1]), int.Parse(arrayOfExpression[i + 1]));
            Console.WriteLine(int.Parse(arrayOfExpression[i - 1]) + " + " + int.Parse(arrayOfExpression[i + 1]) + " = " + sum);
        } else {
            sum += Sum(sum, int.Parse(arrayOfExpression[i + 1]));
            Console.WriteLine(sum + " + " + int.Parse(arrayOfExpression[i + 1]) + " = " + sum);
        }
        Console.WriteLine("TempSum: " + sum);
    } else if (arrayOfExpression[i] == "-") {
        if (i == 1) {
            sum += Deff(int.Parse(arrayOfExpression[i - 1]), int.Parse(arrayOfExpression[i + 1]));
            Console.WriteLine(int.Parse(arrayOfExpression[i - 1]) + " - " + int.Parse(arrayOfExpression[i + 1]) + " = " + sum);
        }
        else {
            sum += Deff(sum, int.Parse(arrayOfExpression[i + 1]));
            Console.WriteLine(sum + " - " + int.Parse(arrayOfExpression[i + 1]) + " = " + sum);
        }
        Console.WriteLine("TempSum: " + sum);
    }
}

// Выводим сумму
Console.WriteLine("Summa: " + sum);
#endregion


#region Задание 6
//TASK:
//Пользователь с клавиатуры вводит некоторый текст.
//Приложение должно изменять регистр первой буквы
//каждого предложения на букву в верхнем регистре.
#endregion


#region Задание 7
//TASK:
//Создайте приложение, проверяющее текст на недопустимые слова.
//Если недопустимое слово найдено, оно должно быть заменено на набор символов *.
//По итогам работы приложения необходимо показать статистику действий.
#endregion