using accountManager;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace finalProject {
    internal class Quiz {
        private string login;

        private AccountManager accountManager = new AccountManager();
        private const string _NAMEFILE = "userResults.txt";
        private const string _PATH = $"D:\\Step\\3 course\\dotNet\\finalProject\\finalProject\\finalProject\\{_NAMEFILE}";

        private Dictionary<string, int> сategoryes;
        private List<(string сategoryes, List<(string question, string[] options, int[] correctAnswer)> body)> quiz;

        private int score = 0;
        private int generalScore = 0;

        public void Play() {
            сategoryes = new Dictionary<string, int> {
                {"История", 0},
                {"География", 0},
                {"Биология", 0},
                {"Программирование", 0}
            };
            string[] сategoryesType = { "История", "География", "Биология", "Программирование" };

            int userChoice = 0;
            bool isNext = false;

            // Вход/Регистрация
            do {
                do {
                    Console.Write("1 - Вход\n2 - Регистрация\n0 - Выход\nВвод: ");
                    userChoice = int.Parse(Console.ReadLine());

                    isNext = !(userChoice == 1 || userChoice == 2 || userChoice == 0);

                    if (isNext) {
                        Console.WriteLine("Вы ввели неверный пункт!\n");
                    }
                } while (isNext);

                if (userChoice == 0) { ClearConsole(); PrintExit(); } else if (userChoice == 1) {
                    ClearConsole();
                    login = accountManager.InputLoginData();

                    //Получить данные из файла в ОЗУ
                    LoadPlayerFromFile(_PATH);
                } else if (userChoice == 2) {
                    ClearConsole();
                    login = accountManager.InputRegisterData();

                    //Запись в файл нового юзера
                    AddPlayerToFile(_PATH);
                }
                Console.WriteLine();
            } while (login == "");
            

            Thread.Sleep(2000);

            
            ClearConsole();
            PrintTitle();


            // MENU
            do {
                Console.Write("\nМЕНЮ:\n" +
                "1 - Стартовать новую викторину\n" +
                "2 - Посмотреть результаты своих прошлых викторин\n" +
                "3 - Посмотреть Топ-20 по конкретной викторине\n" +
                "4 - Изменить настройки: (пароль, дату рождения)\n" +
                "0 - Выход\n" +
                "Ввод: ");
                userChoice = int.Parse(Console.ReadLine());

                isNext = !(userChoice > -1 && userChoice < 5);

                if (isNext) {
                    ClearConsole();
                    Console.WriteLine("Вы ввели неверный пункт!");
                }
            } while (isNext);


            
            if (userChoice == 0) {
                ClearConsole(); PrintExit();
            } else if (userChoice == 1) {
                // Стартовать новую викторину
                ClearConsole(); PrintTitle();
                do {
                    Console.Write("\nВыберите тему викторины:\n" +
                        "1 - История\n" +
                        "2 - География\n" +
                        "3 - Биология\n" +
                        "4 - Программирование\n" +
                        "5 - Смешанная викторина\n" +
                        "Ввод: ");
                    userChoice = int.Parse(Console.ReadLine());

                    isNext = !(userChoice > 0 && userChoice < 6);

                    if (isNext) {
                        ClearConsole();
                        Console.WriteLine("Вы ввели неверный пункт!");
                    }
                } while (isNext);
                ClearConsole();

                quiz = 
                    new List<(string сategoryes, List<(string question, string[] options, int[] correctAnswer)>)> {
                        ("История", new List<(string question, string[] options, int[] correctAnswer)> {
                            ("Кто был первым президентом США?", ["Джордж Вашингтон", "Авраам Линкольн", "Томас Джефферсон", "Теодор Рузвельт"], [0]),
                            ("В каком году началась Вторая мировая война?", ["1939", "1914", "1941", "1945"], [0]),
                            ("Кто основал Монголию?", ["Чингисхан", "Кублайхан", "Бату-хан", "Тамерлан"], [0]),
                            ("Какая страна первой отправила человека в космос?", ["США", "СССР", "Китай", "Германия"], [1]),
                            ("Какая страна была основателем ООН?", ["США", "Великобритания", "Франция", "Все перечисленные"], [0, 1, 2, 3]),
                            ("Кто был первым канцлером Германской империи?", ["Отто фон Бисмарк", "Адольф Гитлер", "Фридрих Великий", "Вильгельм II"], [0]),
                            ("Какая древняя цивилизация построила пирамиды в Египте?", ["Шумеры", "Египтяне", "Майя", "Ацтеки"], [1]),
                            ("Как называлась столица Византийской империи?", ["Константинополь", "Рим", "Афины", "Спарта"], [0]),
                            ("Какое событие считается началом Ренессанса?", ["Падение Константинополя", "Изобретение печатного станка", "Открытие Америки", "Первая мировая война"], [1]),
                            ("Кто открыл Америку?", ["Христофор Колумб", "Фернан Магеллан", "Джеймс Кук", "Васко да Гама"], [0])
                        }),

                        ("География", new List<(string question, string[] options, int[] correctAnswer)> {
                            ("Самая большая страна мира по площади?", ["Канада", "Китай", "США", "Бразилия"], [0]),
                            ("Какой океан самый глубокий?", ["Тихий", "Атлантический", "Индийский", "Северный Ледовитый"], [0]),
                            ("Столица Австралии?", ["Сидней", "Канберра", "Мельбурн", "Брисбен"], [1]),
                            ("Где находятся Гималаи?", ["Азия", "Европа", "Южная Америка", "Северная Америка"], [0]),
                            ("Какая река самая длинная?", ["Амазонка", "Нил", "Миссисипи", "Янцзы"], [1, 0]), // споры о длине
                            ("Какая страна имеет самую большую пустыню?", ["Египет", "Алжир", "США", "Саудовская Аравия"], [1, 2]), // Сахара на нескольких территориях
                            ("Самая высокая гора в мире?", ["Эверест", "К2", "Канченджанга", "Аннапурна"], [0]),
                            ("На каком континенте находится Аргентина?", ["Южная Америка", "Северная Америка", "Европа", "Азия"], [0]),
                            ("В какой стране находятся Мальдивы?", ["Индия", "Шри-Ланка", "Мальдивы — это страна", "Индонезия"], [2]),
                            ("Какая страна граничит с самыми разными государствами?", ["Китай", "США", "Индия", "Бразилия"], [0])
                        }),

                        ("Биология", new List<(string question, string[] options, int[] correctAnswer)>
                        {
                            ("Что является основной структурной единицей жизни?", ["Клетка", "Молекула", "Ткань", "Орган"], [0]),
                            ("Сколько хромосом у человека?", ["46", "23", "48", "42"], [0]),
                            ("Как называется процесс преобразования энергии в растениях?", ["Фотосинтез", "Клеточное дыхание", "Окисление", "Ферментация"], [0]),
                            ("К какой группе животных относятся акулы?", ["Рыбы", "Млекопитающие", "Земноводные", "Рептилии"], [0]),
                            ("Какое из животных является млекопитающим?", ["Дельфин", "Черепаха", "Ястреб", "Лягушка"], [0]),
                            ("Какая группа животных откладывает яйца?", ["Млекопитающие", "Рептилии", "Птицы", "Все перечисленные"], [1, 2, 3]),
                            ("Как называется наука, изучающая растения?", ["Ботаника", "Зоология", "Микробиология", "Экология"], [0]),
                            ("Какое животное известно своим долгим сном?", ["Медведь", "Черепаха", "Ленивец", "Еж"], [0]),
                            ("Какое животное может жить без воды дольше верблюда?", ["Крыса", "Слон", "Кенгуру", "Койот"], [0]),
                            ("Какое из перечисленных животное — насекомое?", ["Пчела", "Паука", "Скорпион", "Омар"], [0])
                        }),

                        ("Программирование", new List<(string question, string[] options, int[] correctAnswer)>
                        {
                            ("Что такое HTML?", ["Язык разметки", "Язык программирования", "Фреймворк", "База данных"], [0]),
                            ("Какой метод используется для вывода информации в консоль в C#?", ["Console.WriteLine()", "Console.Read()", "Console.Print()", "Console.Log()"], [0]),
                            ("Что такое OOP?", ["Объектно-ориентированное программирование", "Открытое исходное программирование", "Программирование на объектных базах", "Функциональное программирование"], [0]),
                            ("Что означает SQL?", ["Structured Query Language", "Secure Query Language", "Simple Query Language", "Standard Query Language"], [0]),
                            ("Какая компания разработала JavaScript?", ["Netscape", "Microsoft", "Google", "Apple"], [0]),
                            ("Какой из перечисленных является языком программирования?", ["Python", "HTML", "SQL", "CSS"], [0]),
                            ("Что такое API?", ["Программный интерфейс приложения", "Сеть баз данных", "Система визуализации", "Программа для анализа"], [0]),
                            ("Что такое JSON?", ["Формат обмена данными", "База данных", "Программа для обработки", "Тип программирования"], [0]),
                            ("Что делает ключевое слово 'static' в C#?", ["Определяет метод или свойство, которые не требуют экземпляра", "Создает новый объект", "Удаляет объект", "Переопределяет метод"], [0]),
                            ("Какая структура данных работает по принципу FIFO?", ["Очередь", "Стек", "Массив", "Список"], [0])
                        })
                    };

                // ИГРА
                foreach (var item in quiz) {
                    if (item.сategoryes != сategoryesType[userChoice - 1]) { continue; }
                    
                    foreach (var itemBody in item.body) {
                        Console.WriteLine($"Категория: {item.сategoryes}\n");

                        Console.WriteLine(itemBody.question);

                        for (int i = 0; i < itemBody.options.Length; i++) {
                            Console.WriteLine($"{i + 1}. {itemBody.options[i]}");
                        }

                        Console.Write("Ваш ответ (введите номер)\n" +
                            "(*введите через пробел, если хотите выбрать несколько пунктов):\n" +
                            "Ввод: ");
                        string userAnswer = Console.ReadLine();
                        string[] tempArrUserAnswer = userAnswer.Split(' ');
                        Array.Sort(tempArrUserAnswer);
                        
                        if (itemBody.correctAnswer.Length == tempArrUserAnswer.Length) {
                            bool isCorrect = false;

                            for (int i = 0; i < itemBody.correctAnswer.Length; i++) {
                                if (itemBody.correctAnswer[i] == int.Parse(tempArrUserAnswer[i]) - 1) {
                                    isCorrect = true;
                                } else {
                                    isCorrect = false;
                                }
                            }

                            if (isCorrect) {
                                Console.WriteLine("Правильно!");
                                score++;
                            } else {
                                PrintCorrectsAnswer(itemBody);
                            }
                        } else {
                            PrintCorrectsAnswer(itemBody);
                        }

                        ClearConsole();
                    }

                    Console.WriteLine($"Ваш итоговый результат: {score} из {item.body.Count()}");

                    // Записываем очки в определённую категорию
                    this.сategoryes[item.сategoryes] += score;
                    generalScore += score;

                    UpdatePlayerData(_PATH);
                }
            } else if (userChoice == 2) {
                // Посмотреть результаты своих прошлых викторин
                Console.WriteLine($"Ник-Нейм: {login}\nОбщий счёт: {generalScore}\nСчёт по категориям:");
                foreach (var item in сategoryes) {
                    Console.WriteLine($"\t{item.Key} = {item.Value} баллов");
                }
            } else if (userChoice == 3) {
                // Посмотреть Топ-20 по конкретной викторине
                Console.WriteLine("Выберите категорию:");

                int i = 0;
                foreach (var item in сategoryes) {
                    Console.WriteLine($"{++i}. - {item.Key}");
                }
                Console.Write("Ввод: ");
                userChoice = int.Parse(Console.ReadLine());

                Console.WriteLine(сategoryesType[userChoice - 1]);

                // USER: test, GENERAL_SCORE: 75, SECTION: [История, 15], [География, 0], [Биология, 10], [Программирование, 50]
                // USER: user, GENERAL_SCORE: 24, SECTION: [История, 6], [География, 0], [Биология, 0], [Программирование, 18]

                FileStream fs = new FileStream(_PATH, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                List<string> listPlayers = new List<string>();
                
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    listPlayers.Add(line);
                }

                sr.Close();
                fs.Close();

                List<(string user, string сategory, int score)> сategoryesTemp = new List<(string user, string сategory, int score)> {};
                foreach (var item in listPlayers) {
                    string[] lineArray = item.Replace(",", " ").Replace("[", "").Replace("]", "").Split(" ");

                    for (int j = 0; j < lineArray.Length; j++) {
                        if (lineArray[j] == сategoryesType[userChoice - 1]) {
                            сategoryesTemp.Add((lineArray[1], lineArray[j], int.Parse(lineArray[j + 2])));
                        }                       
                    }
                }

                var top = сategoryesTemp.OrderByDescending(сategoryesTemp => сategoryesTemp.score).Take(20);

                i = 0;
                foreach (var item in top) {
                    Console.WriteLine($"TOP: {++i}. USER: {item.user}, CATEGORY: {item.сategory} = {item.score} SCORE");
                }
            } else if (userChoice == 4) {
                // Изменить настройки: (пароль, дату рождения)
                do {
                    Console.Write("1 - Изменить пароль\n" +
                        "2 - Изменить дату рождения\n" +
                        "Ввод:");
                    userChoice = int.Parse(Console.ReadLine());

                    isNext = !(userChoice == 1 || userChoice == 2 || userChoice == 0);

                    if (isNext) {
                        Console.WriteLine("Вы ввели неверный пункт!\n");
                    }
                } while (isNext);
                
                if (userChoice == 1) { accountManager.InputChangePasswordData(); }
                else { accountManager.InputChangeDateOfBirthdayData(); }
            }
        }



        private void PrintCorrectsAnswer((string question, string[] options, int[] correctAnswer) body) {
            Console.WriteLine("\nНеправильно!\nПравильные ответы:");

            for (int i = 0; i < body.correctAnswer.Length; i++) {
                Console.WriteLine($"{i + 1}. {body.options[body.correctAnswer[i]]}");
            }

            Thread.Sleep(1000);
        }

        private void AddPlayerToFile(string PATH) {
            FileStream fs = new FileStream(PATH, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            // USER: test, GENERAL_SCORE: 0, SECTION: [История, 0], [География, 0], [Биология, 0], [Программирование, 0]
            string section = string.Empty;
            int i = 0;

            foreach (var item in сategoryes) {
                section += $"[{item.Key}, {item.Value}{(i++ != сategoryes.Count - 1 ? "], " : "]\n")}";
            }
            sw.WriteLine($"USER: {login}, GENERAL_SCORE: {generalScore}, SECTION: {section}");

            sw.Close();
            fs.Close();
        }
        private void LoadPlayerFromFile(string PATH) {
            FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            // USER: test, GENERAL_SCORE: 0, SECTION: [История, 0], [География, 0], [Биология, 0], [Программирование, 0]
            string pattern = @"\[[^,]+, \d+\]";
            MatchCollection matches;

            while (!sr.EndOfStream) {
                string line = sr.ReadLine();
                string[] lineArray = line.Replace(",", " ").Split(" ");

                if (lineArray[1] != login) { continue; }
                
                matches = Regex.Matches(line, pattern);
                foreach (Match match in matches) {
                    string[] tempCategoryes = match.Value.Replace("[", "").Replace("]", "").Split(',');
                    сategoryes[tempCategoryes[0]] = int.Parse(tempCategoryes[1]);
                    generalScore += int.Parse(tempCategoryes[1]);
                }

                break;
            }

            sr.Close();
            fs.Close();
        }
        private void UpdatePlayerData(string PATH) {
            const string TEMP_PATH = $"D:\\Step\\3 course\\dotNet\\finalProject\\finalProject\\finalProject\\userResultsTemp.txt";

            FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            FileStream fsWrite = new FileStream(TEMP_PATH, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fsWrite);

            while (!sr.EndOfStream) {
                string line = sr.ReadLine();
                string[] lineArray = line.Replace(",", " ").Split(" ");
                
                if (lineArray[1] != login) {
                    sw.WriteLine(line);

                    continue;
                }

                string section = string.Empty;
                int i = 0;

                foreach (var item in сategoryes) {
                    section += $"[{item.Key}, {item.Value}{(i++ != сategoryes.Count - 1 ? "], " : "]")}";
                }
                sw.WriteLine($"USER: {login}, GENERAL_SCORE: {generalScore}, SECTION: {section}");
            }

            sw.Close();
            fsWrite.Close();

            sr.Close();
            fs.Close();

            File.Delete(_PATH);
            File.Move(TEMP_PATH, _PATH);
        }

        private void PrintTitle() {
            Console.WriteLine("|\t  ___  _   _ ___ _____\t\t|");
            Console.WriteLine("|\t / _ \\| | | |_ _|__  /\t\t|");
            Console.WriteLine("|\t| | | | | | || |  / / \t\t|");
            Console.WriteLine("|\t| |_| | |_| || | / /_ \t\t|");
            Console.WriteLine("|\t \\__\\_\\\\___/|___/____|\t\t|");
        }
        private void PrintExit() {
            Console.WriteLine("  ____                 _   ____             _ ");
            Console.WriteLine(" / ___| ___   ___   __| | | __ ) _   _  ___| |");
            Console.WriteLine("| |  _ / _ \\ / _ \\ / _` | |  _ \\| | | |/ _ \\ |");
            Console.WriteLine("| |_| | (_) | (_) | (_| | | |_) | |_| |  __/_|");
            Console.WriteLine(" \\____|\\___/ \\___/ \\__,_| |____/ \\__, |\\___(_)");
            Console.WriteLine("                                |___/        ");
        }
        public void ClearConsole() { Console.Clear(); }
    }
}
