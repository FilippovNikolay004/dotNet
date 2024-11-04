using homework;
using System.Text.RegularExpressions;

class MainClass {
    delegate void GetRainbowColorRGB(string color);
    delegate int CountMultiplesOfSeven(int[] arr);
    delegate int CountPositiveNumbers(int[] arr);
    delegate int CountUniqueNegativeNumbers(int[] arr);
    delegate bool ContainsWord(string text, string word);

    static void Main() {
        // Task 1
        GetRainbowColorRGB getRainbowColorRGB = delegate (string color) {
            bool isFound = true;
            string[] colors = new string[7] { "red", "orange", "yellow", "green", "cyan", "blue", "purple"};
            int[][] colorsRGB = new int[][] {
                new int[] { 255, 0, 0 },
                new int[] { 255, 127, 0 },
                new int[] { 255, 255, 0 },
                new int[] { 0, 255, 0 },
                new int[] { 0, 0, 255 },
                new int[] { 75, 0, 130 },
                new int[] { 143, 0, 255 }
            };

            for (int i = 0; i < colors.Length; i++) {
                if (colors[i] == color.ToLower()) {
                    Console.Write("RGB: (");
                    for (int j = 0; j < colorsRGB[i].Length; j++) {
                        Console.Write($"{colorsRGB[i][j] + (j != colorsRGB[i].Length - 1 ? ", " : "")}");
                    }
                    Console.WriteLine(")");
                    isFound = true;
                    break;
                }
                if (i == colors.Length - 1) { isFound = false; }
            }

            if (!isFound) { Console.WriteLine("Цвет не найден!"); }
            
        };
        getRainbowColorRGB("red");
        getRainbowColorRGB("red1");


        // Task 2
        BackpackItem waterBottle = new BackpackItem("Бутылка воды", 1);
        BackpackItem notebook = new BackpackItem("Тетрадть", 1);
        BackpackItem laptop = new BackpackItem("Ноутбук", 5);
        BackpackItem pc = new BackpackItem("Компьютер", 10);
        BackpackItem pen = new BackpackItem("Ручка", 1);

        BackpackItem[] initialContents = { waterBottle, notebook };

        Backpack myBackpack = new Backpack("Чёрный", "Nike", "Nylon", 500, 10, initialContents);
        try {
            myBackpack.AddItem(pen);
            myBackpack.AddItem(pc);
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }


        // Task 3
        Random rnd = new Random();
        int[] arr = new int[15];

        for (int i = 0; i < arr.Length; i++) { arr[i] = rnd.Next(-20, 20); }

        for (int i = 0; i < arr.Length; i++) {
            Console.Write($"{arr[i].ToString() + ((i + 1) != arr.Length ? ", " : "\n")}");
        }

        CountMultiplesOfSeven countMultiplesOfSeven = arr => {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) { if ((arr[i] % 7) == 0) { count++; } }
            return count;
        };
        Console.WriteLine($"Кол-во чисел кратных семи: {countMultiplesOfSeven(arr).ToString()}");

        // Task 4
        CountPositiveNumbers countPositiveNumbers = arr => {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) { if (arr[i] > 0) { count++; } }
            return count;
        };
        Console.WriteLine($"Кол-во положительных чисел: {countPositiveNumbers(arr).ToString()}");

        // Task 5
        CountUniqueNegativeNumbers countUniqueNegativeNumbers = arr => {
            int count = 0;
            for(int i = 0; i < arr.Length; i++) {
                bool isUnique = true;
                for (int j = 0; j < i; j++) { 
                    if (arr[i] == arr[j] || arr[i] > 0) { isUnique = false; break; };
                }
                if (isUnique) { count++; }
            }
            return count;
        };
        Console.WriteLine($"Кол-во уникальных отрицательных чисел: {countUniqueNegativeNumbers(arr).ToString()}");

        // Task 6
        ContainsWord containsWord = (text, word) => {
            // Удаляем все символы, кроме букв и пробелов
            string cleanedInput = Regex.Replace(text, @"[^\w\s]", "");

            // Разбиваем строку на элементы массива и убираем пробелы
            string[] words = cleanedInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++) { if (words[i].ToLower() == word.ToLower()) { return true; } }
            return false;
        };
        const string word = "Lorem";
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        Console.WriteLine($"Слово: '{word}' {(containsWord(text, word) ? "есть" : "нет")} в тексте");
    }
}