using homework;

#region Task1
EmployeeManagement employeeManagement = new EmployeeManagement(
    new Dictionary<string, string>() { { "john_doe", "password123" } },
    new Dictionary<string, string>() { { "jane_smith", "qwerty456" } }
);

employeeManagement.AddLogin("mike_jones", "abc789");
employeeManagement.AddLogin("sara_connor", "pass111");
employeeManagement.AddLogin("bruce_wayne", "batman123");
employeeManagement.PrintDate();

employeeManagement.RemoveLogin("john_doe");
employeeManagement.PrintDate();

employeeManagement.UpdateLogin("jane_smith" , "test", "test");
employeeManagement.PrintDate();

Console.WriteLine(employeeManagement.GetPassword("john_doe"));
Console.WriteLine(employeeManagement.GetPassword("mike_jones"));
#endregion

Console.WriteLine("");

#region Task2
English_FrenchDictionary english_FrenchDictionary = new English_FrenchDictionary();
english_FrenchDictionary.AddWord("hello", "bonjour", "salut");
english_FrenchDictionary.AddWord("goodbye", "au revoir", "adieu");
english_FrenchDictionary.AddWord("thanks", "merci", "remerciements");
english_FrenchDictionary.AddWord("love", "amour", "affection", "tendresse");
english_FrenchDictionary.AddWord("friend", "ami", "copain", "camarade");
english_FrenchDictionary.PrintWords();


Console.WriteLine("= Удаление: ");
english_FrenchDictionary.RemoveTranslation("copain");
english_FrenchDictionary.PrintWords();


Console.WriteLine("= Редактирование слова: ");
english_FrenchDictionary.EditWord("love", "l-ve");
english_FrenchDictionary.PrintWords();


Console.WriteLine("= Редактирование перевода: ");
english_FrenchDictionary.EditTranslation("merci", "merciiiiiii");
english_FrenchDictionary.PrintWords();


Console.WriteLine("= Поиск перевода: ");
english_FrenchDictionary.FindTranslation("hello");
#endregion

Console.WriteLine("");

#region Task3
CoffeeHouse coffeeHouse = new CoffeeHouse();

coffeeHouse.AddVisitor(3, "Alice");
coffeeHouse.AddVisitor(3, "Bob");
coffeeHouse.AddVisitor(3, "Charlie");
coffeeHouse.AddVisitor(1, "Diana");
coffeeHouse.AddVisitor(1, "Eve");


coffeeHouse.SeatCustomer();
coffeeHouse.SeatCustomer();
coffeeHouse.SeatCustomer();


coffeeHouse.FreeTable();
coffeeHouse.SeatCustomer();

/*
 * Все в очереди, кол-во свободных столов = 2
 * 
 * Место свободное? Да - поместить за столик, нет - ждёт в очереди
 * 1й садится за столик. Кол-во свободных столиков--
 * Место свободное? Да - поместить за столик, нет - ждёт в очереди
 * 2й садится за столик. Кол-во свободных столиков--
 * Место свободное? Да - поместить за столик, нет - ждёт в очереди
 * Ждёт в очереди
 * 
 * 1й ушёл
 * Место свободное? Да - поместить за столик, нет - ждёт в очереди
 * 3й садится за столик. Кол-во свободных столиков--
 */
#endregion