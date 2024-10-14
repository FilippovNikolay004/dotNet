using System;

namespace CSharp.Classes
{
    class Student(string _firstName, string _lastName, int _age, double _rating)
    {
        public void Show()
        {
            Console.WriteLine($"{_firstName}\t{_lastName}\t{_age}\t{_rating}");
        }

        // Деконструкторы позволяют выполнить декомпозицию объекта на отдельные части
        public void Deconstruct(out string firstName, out string lastName, out int age, out double rating)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            rating = _rating;
        }
    }
}
