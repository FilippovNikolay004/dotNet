using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Journal {
        public string JournalName { get; set; }
        public string JournalDate { get; set; }
        public string JournalDesc { get; set; }
        public string JournalNumberPhone { get; set; }
        public string JournalEmail { get; set; }
        public float JournalNumberOfEmployees { get; set; }

        public void InputData(string name, string date, string desc, string phone, string email, float numberOfEmployees) {
            JournalName = name;
            JournalDate = date;
            JournalDesc = desc;
            JournalNumberPhone = phone;
            JournalEmail = email;
            JournalNumberOfEmployees = numberOfEmployees;
        }

        public void DisplayData() {
            Console.WriteLine($"Journal Name: {JournalName}");
            Console.WriteLine($"Journal Date: {JournalDate}");
            Console.WriteLine($"Journal Description: {JournalDesc}");
            Console.WriteLine($"Journal Phone: {JournalNumberPhone}");
            Console.WriteLine($"Journal Email: {JournalEmail}");
            Console.WriteLine($"Journal Number Of Employees: {JournalNumberOfEmployees}");
        }

        public static Journal operator +(Journal journal, int value) {
            Journal res = new Journal() {
                JournalName = journal.JournalName,
                JournalDate = journal.JournalDate,
                JournalDesc = journal.JournalDesc,
                JournalNumberPhone = journal.JournalNumberPhone,
                JournalEmail = journal.JournalEmail,
                JournalNumberOfEmployees = (journal.JournalNumberOfEmployees += value)
            };

            return res;
        }

        public static Journal operator +(int value, Journal journal) {
            Journal res = new Journal() {
                JournalName = journal.JournalName,
                JournalDate = journal.JournalDate,
                JournalDesc = journal.JournalDesc,
                JournalNumberPhone = journal.JournalNumberPhone,
                JournalEmail = journal.JournalEmail,
                JournalNumberOfEmployees = (journal.JournalNumberOfEmployees += value)
            };

            return res;
        }

        public static Journal operator -(int value, Journal journal) {
            Journal res = new Journal() {
                JournalName = journal.JournalName,
                JournalDate = journal.JournalDate,
                JournalDesc = journal.JournalDesc,
                JournalNumberPhone = journal.JournalNumberPhone,
                JournalEmail = journal.JournalEmail,
                JournalNumberOfEmployees = (journal.JournalNumberOfEmployees -= value)
            };

            return res;
        }

        public static Journal operator -(Journal journal, int value) {
            Journal res = new Journal() {
                JournalName = journal.JournalName,
                JournalDate = journal.JournalDate,
                JournalDesc = journal.JournalDesc,
                JournalNumberPhone = journal.JournalNumberPhone,
                JournalEmail = journal.JournalEmail,
                JournalNumberOfEmployees = (journal.JournalNumberOfEmployees -= value)
            };

            return res;
        }

        public static bool operator <(Journal journal1, Journal journal2) {
            if (journal1.JournalNumberOfEmployees < journal2.JournalNumberOfEmployees)
                return true;
            else
                return false;
        }

        public static bool operator >(Journal journal1, Journal journal2) {
            if (journal1.JournalNumberOfEmployees > journal2.JournalNumberOfEmployees)
                return true;
            else
                return false;
        }

        public static bool operator ==(Journal journal1, Journal journal2) {
            if (journal1.JournalNumberOfEmployees == journal2.JournalNumberOfEmployees)
                return true;
            else
                return false;
        }

        public static bool operator !=(Journal journal1, Journal journal2) {
            if (!(journal1.JournalNumberOfEmployees == journal2.JournalNumberOfEmployees))
                return true;
            else
                return false;
        }
    }
    internal class Store {
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string StoreProfileDesc { get; set; }
        public string StoreNumberPhone { get; set; }
        public string StoreEmail { get; set; }
        public double StoreSquare { get; set; }

        public void InputData(string name, string address, string profileDesc, string phone, string email, double square) {
            StoreName = name;
            StoreAddress = address;
            StoreProfileDesc = profileDesc;
            StoreNumberPhone = phone;
            StoreEmail = email;
            StoreSquare = square;
        }

        public void DisplayData() {
            Console.WriteLine($"Store Name: {StoreName}");
            Console.WriteLine($"Store Address: {StoreAddress}");
            Console.WriteLine($"Store Profile Description: {StoreProfileDesc}");
            Console.WriteLine($"Store Phone: {StoreNumberPhone}");
            Console.WriteLine($"Store Email: {StoreEmail}");
            Console.WriteLine($"Store Square: {StoreSquare}");
        }
        public static Store operator +(Store store, double value) {
            Store res = new Store() {
                StoreName = store.StoreName,
                StoreAddress = store.StoreAddress,
                StoreProfileDesc = store.StoreProfileDesc,
                StoreNumberPhone = store.StoreNumberPhone,
                StoreEmail = store.StoreEmail,
                StoreSquare = (store.StoreSquare += value)
            };

            return res;
        }

        public static Store operator +(double value, Store store) {
            Store res = new Store() {
                StoreName = store.StoreName,
                StoreAddress = store.StoreAddress,
                StoreProfileDesc = store.StoreProfileDesc,
                StoreNumberPhone = store.StoreNumberPhone,
                StoreEmail = store.StoreEmail,
                StoreSquare = (store.StoreSquare += value)
            };

            return res;
        }

        public static Store operator -(Store store, double value) {
            Store res = new Store() {
                StoreName = store.StoreName,
                StoreAddress = store.StoreAddress,
                StoreProfileDesc = store.StoreProfileDesc,
                StoreNumberPhone = store.StoreNumberPhone,
                StoreEmail = store.StoreEmail,
                StoreSquare = (store.StoreSquare -= value)
            };

            return res;
        }

        public static Store operator -(double value, Store store) {
            Store res = new Store() {
                StoreName = store.StoreName,
                StoreAddress = store.StoreAddress,
                StoreProfileDesc = store.StoreProfileDesc,
                StoreNumberPhone = store.StoreNumberPhone,
                StoreEmail = store.StoreEmail,
                StoreSquare = (store.StoreSquare -= value)
            };

            return res;
        }

        public static bool operator <(Store store1, Store store2) {
            if (store1.StoreSquare < store2.StoreSquare)
                return true;
            else
                return false;
        }

        public static bool operator >(Store store1, Store store2) {
            if (store1.StoreSquare > store2.StoreSquare)
                return true;
            else
                return false;
        }

        public static bool operator ==(Store store1, Store store2) {
            if (store1.StoreSquare == store2.StoreSquare)
                return true;
            else
                return false;
        }

        public static bool operator !=(Store store1, Store store2) {
            if (!(store1.StoreSquare == store2.StoreSquare))
                return true;
            else
                return false;
        }
    }

    internal class ListBooksToRead {
        private string[] books;
        public ListBooksToRead() { books = new string[10]; }
        public ListBooksToRead(int size) { books = new string[size]; }
        public ListBooksToRead(params string[] b) {
            books = new string[b.Length];
            for (int i = 0; i < b.Length; i++)
                books[i] = b[i];
        }
        public void Print() {
            for (int i = 0; i < books.Length; i++)
                Console.WriteLine(books[i]);
        }
        public void AddBook(string name) {
            string[] tempBooks = new string[books.Length + 1];
            for (int i = 0; i < books.Length; i++) {
                tempBooks[i] = books[i];
            }
            tempBooks[books.Length] = name;
            books = tempBooks;
        }
        public static ListBooksToRead operator +(ListBooksToRead books, string name) {
            ListBooksToRead res = new ListBooksToRead(books.books);
            res.AddBook(name);
            return res;
        }
        public static ListBooksToRead operator +(string name, ListBooksToRead books) {
            ListBooksToRead res = new ListBooksToRead(books.books);
            res.AddBook(name);
            return res;
        }

        public void DeleteBook(string name) {
            if (!(ContainsBook(name))) { Console.WriteLine("Такой книги нет в списке!"); return; }

            string[] tempBooks = new string[books.Length - 1];
            for (int i = 0; i < books.Length; i++) {
                if (books[i].ToLower() == name.ToLower()) {
                    books[i] = "-1";
                    break;
                }
            }

            for (int i = 0, j = 0; i < books.Length; i++) {
                if (books[i] != "-1") { tempBooks[j++] = books[i]; }
            }

            books = tempBooks;
        }
        public static ListBooksToRead operator -(ListBooksToRead books, string name) {
            ListBooksToRead res = new ListBooksToRead(books.books);
            res.DeleteBook(name);
            return res;
        }
        public static ListBooksToRead operator -(string name, ListBooksToRead books) {
            ListBooksToRead res = new ListBooksToRead(books.books);
            res.DeleteBook(name);
            return res;
        }

        public bool ContainsBook(string name) {
            for (int i = 0; i < books.Length; i++) {
                if (books[i].ToLower() == name.ToLower()) { return true; }
            }
            return false;
        }
        public string this[int index] {
            get {
                if (index >= 0 && index < books.Length) { return books[index]; }
                else { throw new Exception("\nНекорректный индекс! " + index); }
            }
            set {
                if (index >= 0 && index < books.Length) { books[index] = value; }
                else { throw new Exception("\nНекорректный индекс! " + index); }
            }
        }
    }
}
