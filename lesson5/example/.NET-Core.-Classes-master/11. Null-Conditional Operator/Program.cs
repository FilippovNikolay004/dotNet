using System;

// Начиная с C# 6.0 (Visual Studio 2015) в языке появился элвис-оператор или оператор условного null (Null-Conditional Operator). 
// Он позволяет упростить проверку объектов на значение null в условных конструкциях.

namespace Null_Conditional_Operator
{
    class User
    {
        public string Name { get; set; }
        public Phone Phone { get; set; }
    }

    class Phone
    {
        public string Country { get; set; }
        public Company Company { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new()
            {
                Name = "Tom",
                Phone = new Phone { Country = "South Korea", Company = new Company { Name = "Samsung" } }
            };

            string userName = user == null ? null : user.Name;
            if (userName != null)
                Console.WriteLine(userName);
            string country = user == null ? null : user.Phone == null ? null : user.Phone.Country;
            if (country != null)
                Console.WriteLine(country);
            string companyName = user == null ? null : user.Phone == null ? null : user.Phone.Company == null ? null : user.Phone.Company.Name;
            if (companyName != null)
                Console.WriteLine(companyName);


            if(user?.Name != null)
                Console.WriteLine(user.Name);
            if (user?.Phone?.Country != null)
                Console.WriteLine(user.Phone.Country);
            if (user?.Phone?.Company?.Name != null)
                Console.WriteLine(user.Phone.Company.Name);
        }
    }
}
