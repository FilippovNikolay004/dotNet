#region TASK
/*
Написать класс Money, предназначенный для хранения денежной суммы (в гривнах и копейках).
Для класса реализовать перегрузку операторов
 + (сложение денежных сумм),
 - (вычитание сумм),
 / (деление суммы на целое число),
 * (умножение суммы на целое число),
 ++ (сумма увеличивается на 1 копейку),
 -- (сумма уменьшается на 1 копейку), <, >, == , !=.

Класс не может содержать отрицательную сумму.
В случае если при исполнении какой-либо операции получается отрицательная сумма денег,
то класс генерирует исключительную ситуацию «Банкрот».
Программа должна с помощью меню продемонстрировать все возможности класса Money.
Обработка исключительных ситуаций производится в программе.
*/
#endregion

using homework;

Money money1 = new Money(100, 50);
Money money2 = new Money(50, 65);
Money money3 = new Money(50, 99);

Console.WriteLine(money1 + money2);
Console.WriteLine(money1 - money2);
Console.WriteLine(money1 * money2);
Console.WriteLine(money1 / money2);

Console.WriteLine(money3++);
Console.WriteLine(money3--);

Console.WriteLine(money1 > money2);
Console.WriteLine(money1 < money2);
Console.WriteLine(money1 == money2);
Console.WriteLine(money1 != money2);

Console.WriteLine(new Money(10, 10) - new Money(100, 100));