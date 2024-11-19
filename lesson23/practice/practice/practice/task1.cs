int[] arr = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17};

//  Получить весь масcив целых
var task1 = from i in arr select i;
foreach (var i in task1) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task1 = arr.Select(i => i);
foreach (var i in task1) {
    Console.Write($"{i} ");
}
Console.WriteLine("");


//  Получить четные целые
var task2 = from i in arr
            where i % 2 == 0
            select i;
foreach (var i in task2) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task2 = arr.Where(i => i % 2 == 0);
foreach (var i in task2) {
    Console.Write($"{i} ");
}
Console.WriteLine("");


// Получить нечетные целые
var task3 = from i in arr
            where i % 2 != 0
            select i;
foreach (var i in task3) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task3 = arr.Where(i => i % 2 != 0);
foreach (var i in task3) {
    Console.Write($"{i} ");
}
Console.WriteLine("");


// Получить значения больше заданного
int value = 5;

var task4 = from i in arr
            where i > value
            select i;
foreach (var i in task4) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task4 = arr.Where(i => i > value);
foreach (var i in task4) {
    Console.Write($"{i} ");
}
Console.WriteLine("");


// Получить числа в заданном диапазоне
int fromN = 5;
int toN = 8;

var task5 = from i in arr
            where i > fromN && i < toN
            select i;
foreach (var i in task5) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task5 = arr.Where(i => i > fromN && i < toN);
foreach (var i in task5) {
    Console.Write($"{i} ");
}
Console.WriteLine("");


// Получить числа кратные семи. Результат отсортировать по
//возрастанию
var task6 = from i in arr
            where i % 7 == 0
            orderby i
            select i;
foreach (var i in task6) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task6 = arr.Where(i => i % 7 == 0).OrderBy(i => i);
foreach (var i in task6) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

// Получить числа кратные восьми. Результат отсортировать
//по убыванию
var task7 = from i in arr
            where i % 7 == 0
            orderby i descending
            select i;
foreach (var i in task7) {
    Console.Write($"{i} ");
}
Console.WriteLine("");

task7 = arr.Where(i => i % 7 == 0).OrderByDescending(i => i);
foreach (var i in task7) {
    Console.Write($"{i} ");
}
Console.WriteLine("");