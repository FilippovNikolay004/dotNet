using MyDateNameSpace;

int valueDay = 363;

MyDate date1 = new(18, 10, 2023);
MyDate date2 = new(18, 10, 2024);

Console.WriteLine("Дата 1: " + date1.PrintDate());
Console.WriteLine("Дата 2: " + date2.PrintDate());
Console.WriteLine("");

Console.WriteLine("Разница в днях: " + MyDate.DaysDifference(date1, date2));
Console.WriteLine("Разница в днях: " + MyDate.DaysDifference(date2, date1));
Console.WriteLine("");

date1.AddDaysToDate(363);
Console.WriteLine("Было добавлено: " + valueDay);
Console.WriteLine("Результат: " + date1.PrintDate());