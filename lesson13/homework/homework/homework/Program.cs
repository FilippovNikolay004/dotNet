using namespaceBook;
using namespaceLibrary;

Book[] books = {
    new Book("Война и мир", "Лев Толстой", "Роман", 1225, 1869),
    new Book("Преступление и наказание", "Фёдор Достоевский", "Роман", 671, 1866),
    new Book("Мастер и Маргарита", "Михаил Булгаков", "Фантастика", 480, 1966),
    new Book("Отцы и дети", "Иван Тургенев", "Роман", 254, 1862),
    new Book("Анна Каренина", "Лев Толстой", "Роман", 864, 1877)
};
Library library = new Library(books);
library.PrintAllBooks();

Console.WriteLine("======\n");

// Утипизация
foreach (Book book in library)
    library.PrintAllBooks();
Console.WriteLine("======\n");

// Сортировка по умолчанию
Console.WriteLine("====== СОРТИРОВКА: ======");
Array.Sort(books);
foreach (Book book in books) {
    book.Print();
    Console.WriteLine("");
}
Console.WriteLine("======\n");

// Сортировка по критериям
Console.WriteLine("====== СОРТИРОВКА (по авторам): ======");
Array.Sort(books, new Book.SortByAuthor());
foreach (Book book in books) {
    book.Print();
    Console.WriteLine("");
}
Console.WriteLine("======\n");

Console.WriteLine("====== СОРТИРОВКА (по жанрам): ======");
Array.Sort(books, new Book.SortByGenre());
foreach (Book book in books) {
    book.Print();
    Console.WriteLine("");
}
Console.WriteLine("======\n");

Console.WriteLine("====== СОРТИРОВКА (по кол-во страниц): ======");
Array.Sort(books, new Book.SortByNumberPages());
foreach (Book book in books) {
    book.Print();
    Console.WriteLine("");
}
Console.WriteLine("======\n");

Console.WriteLine("====== СОРТИРОВКА (по дате выпуска): ======");
Array.Sort(books, new Book.SortByReleaseDate());
foreach (Book book in books) {
    book.Print();
    Console.WriteLine("");
}
Console.WriteLine("======\n");

// Глубокое копирование
object booksObj = books.Clone();
Book BooksCopy = booksObj as Book;
foreach (Book book in books) {
    book.Print();
    Console.WriteLine("");
}