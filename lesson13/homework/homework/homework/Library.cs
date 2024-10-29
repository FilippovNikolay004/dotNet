using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using namespaceBook;
namespace namespaceLibrary {
    internal class Library : IEnumerable, IEnumerator {
        private Book[] books;
        private int curpos = -1;

        public Library() {
            books = new Book[10];
        }
        public Library(params Book[] books) {
            this.books = new Book[books.Length];
            for (int i = 0; i < books.Length; i++) { this.books[i] = books[i]; }
        }

        public void PrintAllBooks() {
            for (int i = 0; i < books.Length; i++) { books[i].Print(); Console.WriteLine(""); }
        }

        // Утипизация
        public IEnumerator GetEnumerator() { return this; }

        #region enumerator
        //Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции
        public void Reset() {
            //Console.WriteLine("\nВыполняется метод Reset");
            curpos = -1;
        }
        public object Current // Получает текущий элемент в коллекции
        {
            get {
                //Console.WriteLine("\nВыполняется свойство Current");
                return books[curpos];
            }
        }

        // Перемещает перечислитель к следующему элементу коллекции
        public bool MoveNext() {
            //Console.WriteLine("\nВыполняется метод MoveNext");
            if (curpos < books.Length - 1) {
                curpos++;
                return true;
            } else {
                Reset();
                return false;
            }

        }
        #endregion enumerator
    }
}
