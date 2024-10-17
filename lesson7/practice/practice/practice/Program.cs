#region Задание 3
//TASK:
//Создайте класс «Кредитная карточка».
//Вам необходимо хранить информацию о номере карты,
//ФИО владельца, CVC, дата завершения работы карты и т.д.
//Предусмотреть механизмы для инициализации полей класса.
//Если значение для инициализации неверное, генерируйте исключение.

//CODE:
using CreditCardNamespace;

CreditCard creditCard = new CreditCard();

try {
    creditCard.FirstName = "Nikolay";
    creditCard.LastName = "Filippov";
    creditCard.CVC = 123;
    creditCard.CardCompletionDate = new DateTime(2024, 11, 18);

    Console.WriteLine("Данные верны!");
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
#endregion


#region Задание 4
//Пользователь вводит в строку с клавиатуры математи-ческое выражение.
//Например, 3*2*1*4. Программа должна посчитать результат введенного выражения.
//В строке могут быть только целые числа и оператор *.
//Для обработки ошибок ввода используйте механизм исключений.

//CODE:
static int multi(int a, int b) { return a * b; }

Console.Write("Введите выражение: ");
string expression = Console.ReadLine();

int count = 0;

try {
    for (int i = 0; i < expression.Length; i++) {
        if (!(expression[i] >= '0' && expression[i] <= '9') && expression[i] != '*') {
            throw new Exception("Вы ввели неверное выражение!");
        }
        if (expression[i] >= '0' && expression[i] <= '9') { count++; }
    }

    int[] arrayNumber = new int[count];
    count = 0;

    for (int i = 0; i < expression.Length; i++) {
        if (expression[i] >= '0' && expression[i] <= '9') {
            arrayNumber[count++] = int.Parse(expression[i].ToString());
        }
    }

    int sum = 1;

    for (int i = 0; i < arrayNumber.Length; i++) { sum = multi(sum, arrayNumber[i]); }

    Console.WriteLine("Результат: " + sum);    
}
catch (Exception ex) {
    Console.WriteLine(ex.Message);
}


#endregion