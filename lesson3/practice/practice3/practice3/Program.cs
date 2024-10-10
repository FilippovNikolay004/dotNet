// TASK 1
int[] numbers = new int[] { 1, 3, 5, 1, 3, 6, 7, 9, 2, 8, 1, 3, 1, 3, 5, 6 };
int[] numbers1 = new int[] { 2, 5, 7, 2, 4, 1, 3, 4 };

int maxSize = numbers.Length < numbers1.Length ? numbers.Length : numbers1.Length;
int[] result = new int[maxSize];

int evenNumber = 0; // Чётное
int oddNumber = 0;  // Нечётное
int count = 0; // Кол-во

for (int i = 0; i < numbers.Length; i++) {
    bool isUnique = true;

    if ((numbers[i] % 2) == 0) { evenNumber++; }
    else { oddNumber++; }

    for (int j = 0; j < i; j++) {
        if (numbers[i] == numbers[j]) {
            isUnique = false;
            break;
        }
    }

    if (isUnique) { count++; }
}
Console.WriteLine("Кол-во чётных: " + evenNumber);
Console.WriteLine("Кол-во нечётных: " + oddNumber);
Console.WriteLine("Кол-во уникальных элементво массива: " + count);


// TASK 2
Console.Write("Введите макс. знач.: ");
int max = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++) {
    if (numbers[i] < max) { Console.Write(numbers[i]); }
}
Console.WriteLine();


// TASK 3
// 1, 3, 5
Console.Write("Введите 1е число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите 2е число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите 3е число: ");
int c = int.Parse(Console.ReadLine());

int valueCombination = 0;

for (int i = 0; i < numbers.Length - 3; i++) {
    if (numbers[i] == a && numbers[i + 1] == b && numbers[i + 2] == c) { valueCombination++; }
}

Console.WriteLine("Value: " + valueCombination);


// TASK 4
int index = 0;
for (int i = 0; i < numbers.Length; i++) {
    for (int j = 0; j < numbers1.Length; j++) {
        if (numbers[i] == numbers1[j]) {
            bool isUnique = true;

            for (int k = 0; k < index; k++) {
                if (result[k] == numbers[i]) {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique) {
                result[index++] = numbers[i];
            }
        }
    }
}

#region Как избавиться от 0
    /* Сначала узнать кол-во уникальных парных чисел
     * Создать массив с кол-во уник. парных чисел
     * Заполнить массив
     * Минус: Лишнее интерации (замедленние программы)
    */
#endregion
for (int i = 0; i < result.Length; i++) {
    Console.WriteLine(result[i]);
}