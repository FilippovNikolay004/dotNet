using homework;

Phone[] phones = {
    new Phone("iPhone 14", "Apple", 1200, new DateTime(2023, 9, 10)),
    new Phone("iPhone 14", "Apple", 1200, new DateTime(2023, 9, 10)),
    new Phone("iPhone 13", "Apple", 1000, new DateTime(2022, 9, 15)),
    new Phone("iPhone 12", "Apple", 900, new DateTime(2021, 10, 23)),
    new Phone("Galaxy S23", "Samsung", 1100, new DateTime(2023, 2, 1)),
    new Phone("Galaxy S23", "Samsung", 1100, new DateTime(2023, 2, 1)),
    new Phone("Galaxy S23", "Samsung", 1100, new DateTime(2023, 2, 1)),
    new Phone("Galaxy S22", "Samsung", 950, new DateTime(2022, 2, 25)),
    new Phone("Galaxy S21", "Samsung", 850, new DateTime(2021, 1, 14)),
    new Phone("Nokia 3310", "Nokia", 100, new DateTime(2000, 3, 18)),
    new Phone("Nokia 8.3", "Nokia", 600, new DateTime(2020, 3, 19)),
    new Phone("Nokia X20", "Nokia", 400, new DateTime(2021, 4, 8)),
    new Phone("Galaxy A54", "Samsung", 650, new DateTime(2023, 3, 17))
};

// Посчитайте количество телефонов
var task1 = phones.Select(phones => phones).Count();
Console.WriteLine($"Кол-во телефонов: {task1}");


// Посчитайте количество телефонов с ценой больше 1000
var task2 = phones.Where(phones => phones.Price > 1000).Count();
Console.WriteLine($"Кол-во телефонов с ценой > 1000: {task2}");


// Посчитайте количество телефонов с ценой в диапазоне от 800 до 1000
var task3 = phones.Where(phones => phones.Price > 800 && phones.Price < 1000).Count();
Console.WriteLine($"Кол-во телефонов > 800 и < 1000: {task3}");


// Посчитайте количество телефонов конкретного производителя
var task4 = phones.Where(phones => phones.Manufacturer == "Samsung").Count();
Console.WriteLine($"Кол-во телефонов конкретного произв.: {task4}\n");


// Найдите телефон с минимальной ценой
var task5 = phones.OrderBy(phones => phones.Price).FirstOrDefault();
Console.WriteLine($"\tТелефон с мин. ценой:\n{task5}\n");


// Найдите телефон с максимальной ценой
var task6 = phones.OrderByDescending(phones => phones.Price).FirstOrDefault();
Console.WriteLine($"\tТелефон с макс. ценой:\n{task6}\n");


// Отобразите информацию о самом старом телефоне
var task7 = phones.OrderBy(phones => phones.ReleaseDate).FirstOrDefault();
Console.WriteLine($"\tСамый старый телефон:\n{task7}\n");


// Отобразите информацию о самом свежем телефоне
var task8 = phones.OrderByDescending(phones => phones.ReleaseDate).FirstOrDefault();
Console.WriteLine($"\tСамый новый телефон:\n{task8}\n");


// Найдите среднюю цену телефона
var task9 = phones.Average(phones => phones.Price);
Console.WriteLine($"Средняя цена телефонов: {task9}\n");

// Отобразите пять самых дорогих телефонов
var task10 = phones.OrderByDescending(phones => phones.Price).Take(5);
Console.WriteLine($"\n\tТоп 5 самых дорогих телефонов:");
foreach(var phone in task10) {
    Console.WriteLine($"{phone}\n=====");
}


// Отобразите пять самых дешевых телефонов
var task11 = phones.OrderBy(phones => phones.Price).Take(5);
Console.WriteLine($"\n\tТоп 5 самых дешевых телефонов:");
foreach (var phone in task11) {
    Console.WriteLine($"{phone}\n=====");
}


// Отобразите три самых старых телефона
var task12 = phones.OrderBy(phones => phones.ReleaseDate).Take(3);
Console.WriteLine($"\n\tТоп 3 самых старых телефонов:");
foreach (var phone in task12) {
    Console.WriteLine($"{phone}\n=====");
}


// Отобразите три самых новых телефона
var task13 = phones.OrderByDescending(phones => phones.ReleaseDate).Take(3);
Console.WriteLine($"\n\tТоп 3 самых новых телефонов:");
foreach (var phone in task13) {
    Console.WriteLine($"{phone}\n=====");
}
Console.WriteLine("\n");


// Отобразите статистику по количеству телефонов каждого производителя
var task14 = phones.GroupBy(phones => phones.Manufacturer).Select(g => new { Name = g.Key, Count = g.Count() });
foreach (var item in task14) {
    Console.WriteLine($"Проивзодитель: {item.Name}, кол-во телефонов: {item.Count}");
}
Console.WriteLine("");


// Отобразите статистику по количеству моделей телефонов
var task15 = phones.GroupBy(phones => phones.Manufacturer)
    .Select(g => new { 
        Name = g.Key, 
        Count = g.Select(phone => phone.PhoneName).Distinct().Count() 
    });
foreach (var item in task15) {
    Console.WriteLine($"Проивзодитель: {item.Name}, кол-во моделей: {item.Count}");
}
Console.WriteLine("");


// Отобразите статистику телефонов по годам
var task16 = phones.GroupBy(phones => phones.ReleaseDate)
    .Select(g => new {
        Name = g.Key,
        Count = g.Select(phone => phone.ReleaseDate).Count()
    });
foreach (var item in task16) {
    Console.WriteLine($"{item.Name}, кол-во моделей: {item.Count}");
}