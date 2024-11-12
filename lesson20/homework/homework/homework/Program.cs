using System.Text.RegularExpressions;

string phonePattern = @"^(\(\+380\)|\+380|380|0)\s?\d{2}[-\s]?\d{3}[-\s]?\d{2}[-\s]?\d{2}$";
string emailPattern = @"^[a-zA-Z][\w\.-]*@[a-zA-Z\d-]+\.[a-zA-Z]{2,}$";

Regex regex = new Regex(phonePattern);
Console.Write("Введите номер телефона: ");
string Input = Console.ReadLine();

if (regex.IsMatch(Input)) {
    Console.WriteLine("Ввод корректный");
} else {
    Console.WriteLine("Ввод некорректно");
}

regex = new Regex(emailPattern);
Console.Write("Введите почту: ");
Input = Console.ReadLine();

if (regex.IsMatch(Input)) {
    Console.WriteLine("Ввод корректный");
} else {
    Console.WriteLine("Ввод некорректно");
}