using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountManager {
    public class User {
        public static int CountUsers = 0;

        public int Id { get; set; } = 0;
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirthday { get; set; }

        public User() : this(null, null, null, DateTime.Now) {}
        public User(string login, string password, string email, DateTime dateOfBirthday) {
            Id = CountUsers++;
            Login = login;
            Password = password;
            Email = email;
            DateOfBirthday = dateOfBirthday;
        }
        public User(int startId, string login, string password, string email, DateTime dateOfBirthday) {
            Id = CountUsers = startId;
            CountUsers++;
            Login = login;
            Password = password;
            Email = email;
            DateOfBirthday = dateOfBirthday;
        }
    }

    internal class AccountManager {
        List<User> users = new List<User>();
        FileStream fs;
        const string _NAMEFILE = "users.txt";
        const string _PATH = $"D:\\Step\\3 course\\dotNet\\finalProject\\finalProject\\finalProject\\{_NAMEFILE}";
        private readonly Dictionary<string, int> fieldPositions = new Dictionary<string, int> {
            { "ID", 1 },
            { "LOGIN", 3 },
            { "PASSWORD", 5 },
            { "EMAIL", 7 },
            { "DATE_OF_BIRTHDAY", 9 }
        };

        public AccountManager() { LoadUsersFromFile(_PATH); }


        public string InputRegisterData() {
            string login = CorrectEnter("Создайте логин", "Создайте логин!");
            string email = CorrectEnter("Введите почту", "Введите почту!");
            string password = CorrectEnter("Создайте пароль", "Создайте пароль!", true);

            Console.WriteLine("Введите дату рождения:");
            int day = CorrectEnterDate("Введите день", "Введите день!", 31);
            int month = CorrectEnterDate("Введите месяц", "Введите месяц!", 12);
            int year = CorrectEnterDate("Введите год", "Введите год!", DateTime.Now.Year);
            DateTime dateOfBirthday = new DateTime(year, month, day);

            if (Register(login, password, email, dateOfBirthday)) {
                Console.WriteLine("Регистрация прошла успешно!");
                return login;
            }

            Console.WriteLine("Произошла ошибка регистрации!");
            return "";
        }
        public string InputLoginData() {
            string login = CorrectEnter("Введите логин", "Введите логин!");
            string password = CorrectEnter("Введите пароль", "Введите пароль!", true);

            if (Login(login, password)) {
                Console.WriteLine("Авторизация прошла успешно!");
                return login;
            }

            Console.WriteLine("Неверный логин или пароль!");
            return "";
        }
        public bool InputChangePasswordData() {
            string login = CorrectEnter("Введите логин", "Введите логин!");
            string password = CorrectEnter("Введите старый пароль", "Введите старый пароль!", true);
            
            if (!Login(login, password)) {
                Console.WriteLine("Неверный логин или пароль!");
                return false;
            }

            string newPassword = CorrectEnter("Введите новый пароль", "Введите новый пароль!", true);

            if (ChangePassword(login, password, newPassword)) {
                Console.WriteLine("Пароль успешно изменён!");
                return true;
            }

            Console.WriteLine("Произошла ошибка!");
            return false;
        }
        public bool InputChangeDateOfBirthdayData() {
            string login = CorrectEnter("Введите логин", "Введите логин!");
            string password = CorrectEnter("Введите старый пароль", "Введите старый пароль!", true);

            if (!Login(login, password)) {
                Console.WriteLine("Неверный логин или пароль!");
                return false;
            }

            Console.WriteLine("Введите новую дату рождения:");
            int day = CorrectEnterDate("Введите день", "Введите день!", 31);
            int month = CorrectEnterDate("Введите месяц", "Введите месяц!", 12);
            int year = CorrectEnterDate("Введите год", "Введите год!", DateTime.Now.Year);
            DateTime newDateOfBirthday = new DateTime(year, month, day);

            if (ChangeDateOfBirthday(login, password, newDateOfBirthday)) {
                Console.WriteLine("Пароль успешно изменён!");
                return true;
            }

            Console.WriteLine("Произошла ошибка!");
            return false;
        }


        private string CorrectEnter(string msg, string msgError, bool hideEnter = false) {
            string input = string.Empty;
            bool isNext = false;

            do {
                Console.Write($"{msg}: ");
                if (!hideEnter)
                    input = Console.ReadLine();
                else
                    input = ReadPassword();

                isNext = input == null || input.Length == 0;

                if (isNext) { Console.WriteLine($"{msgError}\n"); }
            } while (isNext);

            return input;
        }
        private int CorrectEnterDate(string msg, string msgError, int maxValue) {
            bool isNext = false;
            int input = 0;

            do {
                Console.Write($"{msg}: ");
                input = int.Parse(Console.ReadLine());

                isNext = input == null || input < 1 || input > maxValue;

                if (isNext) {
                    Console.WriteLine($"{msgError}\n");
                }
            } while (isNext);

            return input;
        }


        public bool Register(string login, string password, string email, DateTime dateOfBirthday) {
            for (int i = 0; i < users.Count; i++) {
                if (users[i].Login == login || users[i].Email == email) {
                    Console.WriteLine("A user with this username or email already exists");
                    return false; 
                }
            }

            users.Add(new User(login, password, email, dateOfBirthday));
            SaveUsersToFile(_PATH);
            return true;
        }
        public bool Login(string login, string password) {
            for (int i = 0; i < users.Count; i++) 
                if (users[i].Login == login && users[i].Password == password) 
                    return true;
            
            return false;
        }


        private void SaveUsersToFile(string PATH) {
            fs = new FileStream(PATH, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"ID: {users.Last().Id}, " +
                $"LOGIN: {users.Last().Login}, " +
                $"PASSWORD: {users.Last().Password}, " +
                $"EMAIL: {users.Last().Email}, " +
                $"DATE_OF_BIRTHDAY: {users.Last().DateOfBirthday}");

            sw.Close();
            fs.Close();
        }
        private void LoadUsersFromFile(string PATH) {
            fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = string.Empty;
            while (!sr.EndOfStream) {
                line = sr.ReadLine();
                string[] tempData = line.Replace(",", "").Split(' ');

                if (line.Length == 0) { continue; }

                int tempYear = int.Parse(tempData[fieldPositions["DATE_OF_BIRTHDAY"]].Split('.')[2]);
                int tempMonth = int.Parse(tempData[fieldPositions["DATE_OF_BIRTHDAY"]].Split('.')[1]);
                int tempDay = int.Parse(tempData[fieldPositions["DATE_OF_BIRTHDAY"]].Split('.')[0]);

                users.Add(new User(
                    int.Parse(tempData[fieldPositions["ID"]]),
                    tempData[fieldPositions["LOGIN"]],
                    tempData[fieldPositions["PASSWORD"]],
                    tempData[fieldPositions["EMAIL"]], 
                    new DateTime(tempYear, tempMonth, tempDay)
                ));
            }

            sr.Close();
            fs.Close();
        }
        private void ChangeUsersInFile(string PATH) {
            PATH = $"D:\\MyClasses\\accountManager\\accountManager\\usersTemp.txt";

            fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach (User user in users) {
                sw.WriteLine($"ID: {user.Id}, " +
                $"LOGIN: {user.Login}, " +
                $"PASSWORD: {user.Password}, " +
                $"EMAIL: {user.Email}, " +
                $"DATE_OF_BIRTHDAY: {user.DateOfBirthday}");
            }

            sw.Close();
            fs.Close();

            File.Delete(_PATH);
            File.Move(PATH, _PATH);
        }
        private string ReadPassword() {
            string password = string.Empty;
            ConsoleKeyInfo key;

            do {
                // Не отображает вводимые символы
                key = Console.ReadKey(intercept: true); 

                if (key.Key == ConsoleKey.Backspace && password.Length > 0) {
                    // Удаление символа из пароля
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b"); // Удаляет символ в консоли
                } else if (!char.IsControl(key.KeyChar)) {
                    // Добавление символа в пароль
                    password += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter); // Завершение ввода по Enter
            Console.WriteLine();

            return password;
        }


        private void PrintColumnInfo() {
            Console.WriteLine($"{"ID",-5}{"LOGIN",-10}{"PASSWORD",-10}{"DATE_OF_BIRTHDAY",-15}");
        }
        public void PrintData() {
            PrintColumnInfo();
            for (int i = 0; i < users.Count; i++) { PrintUserId(i); }
        }
        private void PrintUserId(int i) {
            Console.WriteLine($"{users[i].Id, -5}{users[i].Login, -10}{users[i].Password, -10}{users[i].DateOfBirthday, -15}");
        }


        public void SearchUser(string login) {
            int index = GetIndexByLogin(login);
            if (index != -1) { PrintColumnInfo(); PrintUserId(index); return; }

            Console.WriteLine("User not found");
        }
        public bool UserExists(string login) {
            int index = GetIndexByLogin(login);
            if (index == -1) return false;
            return true;
        }
        private int GetIndexByLogin(string login) {
            for (int i = 0; i < users.Count; i++)
                if (users[i].Login == login) return i;
            return -1;
        }


        public bool ChangePassword(string login, string oldPassword, string newPassword) {
            int index = GetIndexByLogin(login);
            
            if (index == -1) { return false; }
            if (!Login(login, oldPassword)) { Console.WriteLine("Invalid login or password entered!"); return false; }
        
            users[index].Password = newPassword;

            ChangeUsersInFile(_PATH);

            return true;
        }
        public bool ChangeDateOfBirthday(string login, string password, DateTime newDateOfBirthday) {
            int index = GetIndexByLogin(login);

            if (index == -1) { return false; }
            if (!Login(login, password)) { Console.WriteLine("Invalid login or password entered!"); return false; }

            users[index].DateOfBirthday = newDateOfBirthday;

            ChangeUsersInFile(_PATH);

            return true;
        }
    }
}