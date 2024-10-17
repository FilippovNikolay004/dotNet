#region Задание 3
//TASK:
//Пользователь вводит строку с клавиатуры.
//Необходимо зашифровать данную строку используя шифр Цезаря.

//CODE:
using System.Text;

char[] character = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
StringBuilder text = new StringBuilder("Hello world");

Console.WriteLine("Изначальный текст: " + text.ToString());

for (int i = 0; i < text.Length; i++) {
    for (int j = 0, c = 0; j < character.Length; j++, c++) {
        if (text[i].ToString().ToLower() == character[c].ToString()) {
            if ((c + 3) >= character.Length) { c = -1; }

            text[i] = character[c + 3];
            break;
        }
    }
}

Console.WriteLine("Результат: " + text.ToString());
Console.WriteLine("");
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
bool isNext = false;

do {
    Console.Write("Введите выражение: ");
    expression = Console.ReadLine();

    isNext = expression == null;

    if (isNext) { Console.WriteLine("Вы ввели пустую строку!"); }
    Console.WriteLine("");
} while (isNext);

// Очистка от лишних пробелов
expression = expression.Replace(" ", "");
Console.WriteLine("Выражение: " + expression);

// Добавляем символы для разделения на элементы
expression = expression.Replace("+", "_+_");
expression = expression.Replace("-", "_-_");

// Разбиваем строку на элемены массива
string[] arrayOfExpression = expression.Split(new Char[] {'_'}, StringSplitOptions.RemoveEmptyEntries);

//1-1-2-3+10+1

int sum = int.Parse(arrayOfExpression[0]);
for (int i = 1; i < arrayOfExpression.Length; i++) {
    if (arrayOfExpression[i] == "-") {
        sum = Deff(sum, int.Parse(arrayOfExpression[i + 1]));
    } else if (arrayOfExpression[i] == "+") {
        sum = Sum(sum, int.Parse(arrayOfExpression[i + 1]));
    }
}

// Выводим сумму
Console.WriteLine("Сумма: " + sum);
Console.WriteLine("");
#endregion


#region Задание 6
//TASK:
//Пользователь с клавиатуры вводит некоторый текст.
//Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.

text = new StringBuilder();

//string textTemp = Console.ReadLine();
string textTemp = "Lorem Ipsum  is simply dummy  text of and typesetting industry.lorem of  type and scrambled it to make a type specimen book. it has the remaining essentially unchanged. it the PageMaker including.";
string result = string.Join(" ", textTemp.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

text.AppendLine(result.ToString());

Console.WriteLine("Изначальный текст: ");
Console.WriteLine(result);
Console.WriteLine("");

for (int i = 0; i < text.Length; i++) {
    if (text[i] == '.') {
        if (text[i + 1] == ' ') { text[i + 2] = char.ToUpper(text[i + 2]); }
        else { text[i + 1] = char.ToUpper(text[i + 1]); }
    }
}

Console.WriteLine("Результат: ");
Console.WriteLine(text);
#endregion


#region Задание 7
//TASK:
//Создайте приложение, проверяющее текст на недопустимые слова.
//Если недопустимое слово найдено, оно должно быть заменено на набор символов *.
//По итогам работы приложения необходимо показать статистику действий.

//CODE:
string[] forbiddenWords = { "dummy", "text", "lorem", "book" };
char[] signs = { '.', ',', '-', '(', ')', '?'};

textTemp = "Lorem Ipsum  is simply dummy  text of and typesetting industry.lorem of  type and, scrambled it to make a type specimen book. it has the remaining essentially unchanged. it the PageMaker including.";

for (int i = 0; i < signs.Length; i++) { textTemp = textTemp.Replace(signs[i].ToString(), $"_{signs[i].ToString()}_"); }

string[] worksText = textTemp.Split(new[] { '_', ' ' }, StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < worksText.Length; i++) {
    string temp = string.Empty;

    for (int j = 0; j < forbiddenWords.Length; j++) {
        if (worksText[i].ToLower() == forbiddenWords[j].ToLower()) {
            for (int k = 0; k < worksText[i].Length; k++) { temp += "*";}
            worksText[i] = temp;
        }
    }
}

textTemp = string.Empty;
for (int i = 0; i < worksText.Length; i++) {
    if (worksText[i] == ".") {
        textTemp += ".";
    } else if (worksText[i] == ",") {
        textTemp += ",";
    } else {
        textTemp += i == 0 ? worksText[i] : " " + worksText[i];
    }
}
Console.WriteLine(textTemp);
#endregion