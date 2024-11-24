using homework;
using System.Linq;

Firm[] firms = new Firm[] {
    new Firm("Firm A", new DateTime(2020, 1, 1), new Director("John", "Doe"), "Technology", 290, "Address 1",
        [
            new Employee("John", "Doe", "Manager", "123-456-7890", "john.doe@example.com", 5000),
            new Employee("Jane", "Smith", "Developer", "987-654-3210", "jane.smith@example.com", 4000),
            new Employee("Alice", "Brown", "Designer", "555-123-4567", "alice.brown@example.com", 3500),
            new Employee("Bob", "Johnson", "QA Engineer", "444-222-3333", "bob.johnson@example.com", 3000),
            new Employee("Emily", "Davis", "HR Specialist", "111-333-5555", "emily.davis@example.com", 4500)
        ]
    ),
    new Firm("tWhite B", new DateTime(2001, 2, 2), new Director("Jane", "Smith"), "Consulting", 75, "Address 2",
        [
            new Employee("Emily", "Taylor", "Manager", "666-777-8888", "dichael.taylor@example.com", 4700),
            new Employee("Sophia", "Wilson", "Data Analyst", "222-999-1111", "sophia.wilson@example.com", 4200),
            new Employee("David", "Miller", "Marketing Specialist", "888-666-4444", "david.miller@example.com", 3900),
            new Employee("Olivia", "Moore", "Accountant", "333-444-5555", "olivia.moore@example.com", 3600),
            new Employee("Chris", "Anderson", "IT Support", "777-888-9999", "chris.anderson@example.com", 3100)
        ]
    ),
    new Firm("White C", new DateTime(2023, 3, 3), new Director("Alice", "Brown"), "Manufacturing", 110, "Address 3",
        [
            new Employee("Ethan", "Harris", "Manager", "321-654-9870", "dihan.harris@example.com", 5200),
            new Employee("Mia", "Clark", "UI/UX Designer", "654-321-7890", "mia.clark@example.com", 3700),
            new Employee("Daniel", "Martinez", "Software Architect", "789-123-4567", "daniel.martinez@example.com", 6000),
            new Employee("Ava", "Lewis", "Content Writer", "456-789-1234", "ava.lewis@example.com", 2800),
            new Employee("Lucas", "Young", "Manager", "123-987-6543", "lucas.young@example.com", 4800)
        ]
    ),
    new Firm("Firm D", new DateTime(2023, 4, 4), new Director("Bob", "Johnson"), "Retail", 25, "Address 4",
        [
            new Employee("Emma", "King", "Legal Advisor", "999-111-2222", "dima.king@example.com", 5300),
            new Employee("Liam", "Scott", "Product Owner", "888-444-3333", "liam.scott@example.com", 5500),
            new Employee("Charlotte", "Adams", "Researcher", "777-222-1111", "charlotte.adams@example.com", 3900),
            new Employee("James", "Hall", "Security Analyst", "666-333-4444", "james.hall@example.com", 4600),
            new Employee("Isabella", "Turner", "Business Analyst", "555-666-7777", "isabella.turner@example.com", 4100)
        ]
    ),
    new Firm("Firm E", new DateTime(2004, 5, 5), new Director("Charlie", "Davis"), "Finance", 80, "Address 5",
        [
            new Employee("Benjamin", "White", "Support Engineer", "123-321-4567", "benjamin.white@example.com", 3100),
            new Employee("Harper", "Evans", "Recruiter", "654-789-3210", "harper.evans@example.com", 3400),
            new Employee("Henry", "Baker", "DevOps Engineer", "456-123-7890", "henry.baker@example.com", 5900),
            new Employee("Ella", "Harris", "Technical Writer", "789-456-1234", "ella.harris@example.com", 3000),
            new Employee("Jack", "Rivera", "Finance Manager", "987-654-3210", "jack.rivera@example.com", 5100)
        ]
    ),
    new Firm("Food F", new DateTime(2005, 6, 6), new Director("Emily", "Wilson"), "Healthcare", 45, "Address 6",
        [
            new Employee("Lily", "Wright", "Public Relations Specialist", "555-888-2222", "lily.wright@example.com", 3700),
            new Employee("Owen", "Mitchell", "Backend Developer", "234-555-6666", "owen.mitchell@example.com", 4600),
            new Employee("Grace", "Perez", "Frontend Developer", "333-222-1111", "grace.perez@example.com", 4200),
            new Employee("Elijah", "Cooper", "Team Lead", "222-333-4444", "elijah.cooper@example.com", 5000),
            new Employee("Victoria", "Bailey", "Manager", "111-444-3333", "victoria.bailey@example.com", 4800)
        ]
    ),
    new Firm("White G", new DateTime(2022, 7, 7), new Director("David", "Miller"), "Education", 60, "Address 7",
        [
            new Employee("Mason", "Carter", "SEO Specialist", "999-888-7777", "mason.carter@example.com", 4000),
            new Employee("Scarlett", "Richardson", "Copywriter", "888-555-6666", "scarlett.richardson@example.com", 3500),
            new Employee("Evelyn", "Sanchez", "Data Scientist", "237-999-8888", "evelyn.sanchez@example.com", 6000),
            new Employee("Logan", "Reed", "Network Engineer", "444-333-2222", "logan.reed@example.com", 5300),
            new Employee("Abigail", "Morgan", "Office Manager", "333-666-5555", "abigail.morgan@example.com", 3200)
        ]
    ),
    new Firm("Firm H", new DateTime(2007, 8, 8), new Director("Sophia", "Moore"), "Real Estate", 35, "Address 8",
        [
            new Employee("Chloe", "Foster", "Graphic Designer", "555-444-3333", "chloe.foster@example.com", 3700),
            new Employee("Sebastian", "Gray", "Mobile Developer", "222-111-8888", "sebastian.gray@example.com", 4500),
            new Employee("Madison", "Bell", "Event Planner", "999-222-4444", "madison.bell@example.com", 3600),
            new Employee("Samuel", "Ross", "Full Stack Developer", "888-999-3333", "samuel.ross@example.com", 5400),
            new Employee("Hannah", "Ortiz", "Marketing Analyst", "777-111-5555", "hannah.ortiz@example.com", 4100)
        ]
    ),
    new Firm("Food I", new DateTime(2020, 9, 9), new Director("Michael", "Taylor"), "Hospitality", 90, "Address 9",
        [
            new Employee("Jacob", "Griffin", "Chief Technology Officer", "666-444-8888", "jacob.griffin@example.com", 7500),
            new Employee("Zoe", "Diaz", "Social Media Manager", "235-222-3333", "zoe.diaz@example.com", 3300),
            new Employee("Aiden", "Hayes", "Technical Recruiter", "444-777-9999", "aiden.hayes@example.com", 3800),
            new Employee("Layla", "Hughes", "Operations Specialist", "111-999-8888", "layla.hughes@example.com", 4200),
            new Employee("Gabriel", "Ramirez", "Quality Manager", "222-666-5555", "gabriel.ramirez@example.com", 4700)
        ]
    ),
    new Firm("Food J", new DateTime(2024, 11, 10), new Director("Olivia", "Anderson"), "Media", 70, "Address 10",
        [
            new Employee("Ella", "Stewart", "Chief Marketing Officer", "123-789-4560", "ella.stewart@example.com", 7100),
            new Employee("Isaac", "Murphy", "Cybersecurity Specialist", "456-321-7890", "isaac.murphy@example.com", 4900),
            new Employee("Amelia", "Cook", "Video Editor", "789-123-6540", "amelia.cook@example.com", 3200),
            new Employee("Nathan", "Rivera", "Supply Chain Manager", "321-654-1230", "nathan.rivera@example.com", 5300),
            new Employee("Sofia", "Powell", "Administrative Assistant", "654-987-3210", "sofia.powell@example.com", 3100)
        ]
    )
};


// Получить информацию обо всех фирмах
Console.WriteLine("* Получить информацию обо всех фирмах:");
var task1 = firms.Select(firms => firms);
foreach (var item in task1) { Console.WriteLine($"{item}\n"); }

task1 = from firm in firms
        select firm;
foreach (var item in task1) { Console.WriteLine($"{item}\n"); }


// Получить фирмы, у которых в названии есть слово Food
Console.WriteLine("* Получить фирмы, у которых в названии есть слово Food:");
var task2 = firms.Where(firms => firms.Name.StartsWith("Food"));
foreach (var item in task2) { Console.WriteLine($"{item}\n"); }

task2 = from firm in firms
        where firm.Name.StartsWith("Food")
        select firm;
foreach (var item in task2) { Console.WriteLine($"{item}\n"); }


// Получить фирмы, которые работают в области Technology
Console.WriteLine("* Получить фирмы, которые работают в области Technology");
var task3 = firms.Where(firms => firms.BusinessProfile == "Technology");
foreach (var item in task3) { Console.WriteLine($"{item}\n"); }

task3 = from firm in firms
        where firm.BusinessProfile == "Technology"
        select firm;
foreach (var item in task3) { Console.WriteLine($"{item}\n"); }


// Получить фирмы, которые работают в области Education или Media
Console.WriteLine("* Получить фирмы, которые работают в области Education или Media");
var task4 = firms.Where(firms => firms.BusinessProfile == "Education" || firms.BusinessProfile == "Media");
foreach (var item in task4) { Console.WriteLine($"{item}\n"); }

task4 = from firm in firms
        where firm.BusinessProfile == "Education" || firm.BusinessProfile == "Media"
        select firm;
foreach (var item in task4) { Console.WriteLine($"{item}\n"); }


// Получить фирмы с количеством сотрудников, большем 100
Console.WriteLine("* Получить фирмы с количеством сотрудников, большем 100");
var task5 = firms.Where(firms => firms.QuantityEmployees > 100);
foreach (var item in task5) { Console.WriteLine($"{item}\n"); }

task5 = from firm in firms
        where firm.QuantityEmployees > 100
        select firm;
foreach (var item in task5) { Console.WriteLine($"{item}\n"); }



// Получить фирмы с количеством сотрудников в диапазоне от 100 до 300
Console.WriteLine("* Получить фирмы с количеством сотрудников в диапазоне от 100 до 300");
var task6 = firms.Where(firms => firms.QuantityEmployees < 300 && firms.QuantityEmployees > 100);
foreach (var item in task6) { Console.WriteLine($"{item}\n"); }

task6 = from firm in firms
        where firm.QuantityEmployees < 300 && firm.QuantityEmployees > 100
        select firm;
foreach (var item in task6) { Console.WriteLine($"{item}\n"); }


// Получить фирмы, которые находятся в Address 1
Console.WriteLine("* Получить фирмы, которые находятся в Address 1");
var task7 = firms.Where(firms => firms.Address == "Address 1");
foreach (var item in task7) { Console.WriteLine($"{item}\n"); }

task7 = from firm in firms
        where firm.Address == "Address 1"
        select firm;
foreach (var item in task7) { Console.WriteLine($"{item}\n"); }


// Получить фирмы, у которых фамилия директора Miller
Console.WriteLine("* Получить фирмы, у которых фамилия директора Miller");
var task8 = firms.Where(firms => firms.Director.LastName == "Miller");
foreach (var item in task8) { Console.WriteLine($"{item}\n"); }

task8 = from firm in firms
        where firm.Director.LastName == "Miller"
        select firm;
foreach (var item in task8) { Console.WriteLine($"{item}\n"); }


// Получить фирмы, которые основаны больше двух лет назад
Console.WriteLine("* Получить фирмы, которые основаны больше двух лет назад");
var task9 = firms.Where(firms => (DateTime.Now.Year - firms.FoundingDate.Year) > 2);
foreach (var item in task9) { Console.WriteLine($"{item}\n"); }

task9 = from firm in firms
        where (DateTime.Now.Year - firm.FoundingDate.Year) > 2
        select firm;
foreach (var item in task9) { Console.WriteLine($"{item}\n"); }


// Получить фирмы со дня основания, которых прошло 123 дня
Console.WriteLine("* Получить фирмы со дня основания, которых прошло 123 дня");
var task10 = firms.Where(firms => (DateTime.Now - firms.FoundingDate).Days > 123);
foreach (var item in task10) { Console.WriteLine($"{item}\n"); }


// Получить фирмы, у которых фамилия директора Smith и название фирмы содержит слово White
bool ContainsWord(string name, string word) {
    if (name.Contains(word, StringComparison.OrdinalIgnoreCase))
        return true;
    return false;
}

Console.WriteLine("* Получить фирмы, у которых фамилия директора Smith и название фирмы содержит слово White");
var task11 = firms.Where(firms => firms.Director.LastName == "Smith" && ContainsWord(firms.Name, "White"));
foreach (var item in task11) { Console.WriteLine($"{item}\n"); }

task11 =  from firm in firms
          where firm.Director.LastName == "Smith" && ContainsWord(firm.Name, "White")
          select firm;
foreach (var item in task11) { Console.WriteLine($"{item}\n"); }



// TASK 3
Console.WriteLine("\t============== TASK 3 ==============\n");
// Получить всех сотрудников конкретной фирмы
Console.WriteLine("* Получить всех сотрудников конкретной фирмы");
var taskE1 = firms.Where(firms => firms.Name == "Firm H");
foreach (var item in taskE1) {
    foreach (var itemEmployee in item.Employee) {
        Console.WriteLine($"{itemEmployee}\n");
    }
}


// Получить всех сотрудников конкретной фирмы, у которых заработные платы больше заданной
Console.WriteLine("* Получить всех сотрудников конкретной фирмы, у которых заработные платы больше заданной");
var taskE2 = from firmItem in firms
             where firmItem.Name == "Firm H"
             select (from firmEmployee in firmItem.Employee
                     where firmEmployee.Salary > 4000
                     select firmEmployee);
taskE2 = firms
    .Where(firms => firms.Name == "Firm H")
    .Select(firms => firms.Employee
        .Where(employee => employee.Salary > 4000));

foreach (var item in taskE2) {
    foreach (var itemEmployee in item) {
        Console.WriteLine($"{itemEmployee}\n");
    }
}


// Получить сотрудников всех фирм, у которых должность Manager // ПЕРЕДЕЛАТЬ
Console.WriteLine("* Получить сотрудников всех фирм, у которых должность Manager");
var taskE3 = from firmItem in firms
             select (from firmEmployee in firmItem.Employee
                     where firmEmployee.Post == "Manager"
                     select firmEmployee);

foreach (var item in taskE3) {
    foreach (var itemEmployee in item) {
        Console.WriteLine($"{itemEmployee}\n");
    }
}


// Получить сотрудников, у которых телефон начинается с 23
Console.WriteLine("* Получить сотрудников, у которых телефон начинается с 23");
var taskE4 = firms.Select(firms => firms.Employee.Where(employee => employee.PhoneNumber.StartsWith("23")));
foreach (var item in taskE4) {
    foreach (var itemEmployee in item) { Console.WriteLine($"{itemEmployee}\n"); }
}


// Получить сотрудников, у которых Email начинается с di
Console.WriteLine("* Получить сотрудников, у которых Email начинается с di");
var taskE5 = firms.Select(firms => firms.Employee.Where(employee => employee.Email.StartsWith("di")));
foreach (var item in taskE5) {
    foreach (var itemEmployee in item) { Console.WriteLine($"{itemEmployee}\n"); }
}


// Получить сотрудников, у которых имя Emily
Console.WriteLine("* Получить сотрудников, у которых имя Emily");
var taskE6 = firms.Select(firms => firms.Employee.Where(employee => employee.FirstName.StartsWith("Emily")));
foreach (var item in taskE6) {
    foreach (var itemEmployee in item) { Console.WriteLine($"{itemEmployee}\n"); }
}