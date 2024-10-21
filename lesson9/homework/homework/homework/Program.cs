using homework;

Journal journal = new Journal();
journal.InputData(
    "Tech Journal",
    "2024-10-21",
    "Описание технического журнала",
    "+123456789",
    "techjournal@example.com",
    50
);
Console.WriteLine("Информация о журнале:");
journal.DisplayData();

Console.WriteLine("\nОбновлённая информация о журнале:");
journal = journal + 15;
journal.DisplayData();

Console.WriteLine("\nОбновлённая информация о журнале:");
journal = journal - 25;
journal.DisplayData();


Store store = new Store();
store.InputData(
    "Tech Store",
    "123 Main St, City",
    "Магазин технических товаров",
    "+987654321",
    "techstore@example.com",
    45.5
);
Console.WriteLine("\nИнформация о магазине:");
store.DisplayData();

Console.WriteLine("\nОбновлённая информация о магазине:");
store = store + 5.5;
store.DisplayData();

Console.WriteLine("\nОбновлённая информация о магазине:");
store = store - 5;
store.DisplayData();


ListBooksToRead listBooksToRead = new ListBooksToRead(
    "Война и мир",
    "Преступление и наказание",
    "Мастер и Маргарита",
    "Анна Каренина",
    "Железное пламя");
Console.WriteLine("");
listBooksToRead.Print();
listBooksToRead.AddBook("Ведьмак: последнее желание");
listBooksToRead = listBooksToRead + "METRO2033";
listBooksToRead = listBooksToRead + "TEST";
listBooksToRead = listBooksToRead + "HelloWorld";
Console.WriteLine("");

for (int i = 0; i < 20; i++) {
    try {
        Console.WriteLine(listBooksToRead[i]);
    } catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine("");

listBooksToRead.DeleteBook("test");
listBooksToRead = listBooksToRead - "helloWorld";

if (listBooksToRead.ContainsBook("Ведьмак: последнее желание")) {
    Console.WriteLine("== Книга есть в списке! ==\n");
} else {
    Console.WriteLine("== Книги нет в списке! ==\n");
}

for (int i = 0; i < 20; i++) {
    try {
        Console.WriteLine(listBooksToRead[i]);
    }
    catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
}