string[] cities = { "Киев", "Харьков", "Одесса", "Днепр", "Львов", "Запорожье", "Винница", "Чернигов", "Полтава", "Ивано-Франковск" };

// Получить весь масcив городов
var task1 = from i in cities
            select i;
foreach (var i in task1) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task1 = cities.Select(i => i);
foreach (var i in task1) {
    Console.Write($"{i} ");
}
Console.WriteLine("");


// Получить города с длиной названия равной заданному
int length = 6;

var task2 = from i in cities
            where i.Length == length
            select i;
foreach (var i in task2) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task2 = cities.Where(i => i.Length == length);
foreach (var i in task2) {
    Console.Write($"{i} ");
}
Console.WriteLine("");


// Получить города названия, которых начинается с буквы О
var task3 = from i in cities
            where i.ToLower().StartsWith('о')
            select i;
foreach (var i in task3) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task3 = cities.Where(i => i.ToLower().StartsWith('о'));
foreach (var i in task3) {
    Console.Write($"{i} ");
}
Console.WriteLine("");


// Получить города названия, которых заканчивается на букву в
var task4 = from i in cities
            where i.ToLower().EndsWith('в')
            select i;
foreach (var i in task4) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task4 = cities.Where(i => i.ToLower().EndsWith('в'));
foreach (var i in task4) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

// Получить города названия, которых начинаются на О и заканчиваются на букву А
var task5 = from i in cities
            where i.ToLower().StartsWith('о') && i.ToLower().EndsWith('а')
            select i;
foreach (var i in task5) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task5 = cities.Where(i => i.ToLower().StartsWith('о') && i.ToLower().EndsWith('а'));
foreach (var i in task5) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

// Получить города названия, которых начинаются на Ne. Результат отсортировать по убыванию
var task6 = from i in cities
            where i.ToLower().StartsWith("ха")
            orderby i descending
            select i;
foreach (var i in task6) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task6 = cities.Where(i => i.ToLower().StartsWith("ха")).OrderByDescending(i => i);
foreach (var i in task6) {
    Console.Write($"{i} ");
}
Console.WriteLine("");