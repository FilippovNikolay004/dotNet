using namespaceLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaceBook {
    internal class Book : IComparable, ICloneable {
        public string NameBook { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int NumberPages { get; set; }
        public int ReleaseDate { get; set; }

        public Book() { 
            NameBook = string.Empty;
            Author = string.Empty;
            Genre = string.Empty;
            NumberPages = 0;
            ReleaseDate = 0;
        }
        public Book(string nameBook, string author, string genre, int numberPages, int releaseDate) {
            NameBook = nameBook;
            Author = author;
            Genre = genre;
            NumberPages = numberPages;
            ReleaseDate = releaseDate;
        }

        public void Input() {
            Console.Write("Название книги: ");
            NameBook = Console.ReadLine();

            Console.Write("Автор: ");
            Author = Console.ReadLine();

            Console.Write("Жанр: ");
            Genre = Console.ReadLine();

            Console.Write("Кол-во страниц: ");
            NumberPages = int.Parse(Console.ReadLine());

            Console.Write("Год выпуска: ");
            ReleaseDate = int.Parse(Console.ReadLine());
        }

        public void Print() {
            Console.WriteLine($"Название книги: {NameBook}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Кол-во страниц: {NumberPages}");
            Console.WriteLine($"Год выпуска: {ReleaseDate}");
        }

        // Глубокое копирование
        public object Clone() { return new Book(NameBook, Author, Genre, NumberPages, ReleaseDate); }

        // Сортировка по умолчанию
        public int CompareTo(object obj) {
            if (obj is Book)
                return NameBook.CompareTo((obj as Book).NameBook);

            throw new NotImplementedException();
        }

        // Сортировка по критериям
        public class SortByNameBook :IComparer {
            int IComparer.Compare(object obj1, object obj2) {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).NameBook.CompareTo((obj2 as Book).NameBook);

                throw new NotImplementedException();
            }
        }
        public class SortByAuthor :IComparer {
            int IComparer.Compare(object obj1, object obj2) {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).Author.CompareTo((obj2 as Book).Author);

                throw new NotImplementedException();
            }
        }
        public class SortByGenre :IComparer {
            int IComparer.Compare(object obj1, object obj2) {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).Genre.CompareTo((obj2 as Book).Genre);

                throw new NotImplementedException();
            }
        }
        public class SortByNumberPages :IComparer {
            int IComparer.Compare(object obj1, object obj2) {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).NumberPages.CompareTo((obj2 as Book).NumberPages);

                throw new NotImplementedException();
            }
        }
        public class SortByReleaseDate :IComparer {
            int IComparer.Compare(object obj1, object obj2) {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).ReleaseDate.CompareTo((obj2 as Book).ReleaseDate);

                throw new NotImplementedException();
            }
        }
    }
}
