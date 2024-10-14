#region Задание 1
// TASK:
//Создать массив из 10 случайных чисел в диапазоне от 0 до 5.
//Сжать массив, удалив из него все 0, и заполнить освободившиеся справа элементы значениями -1.

// CODE:
int[] arr = new int[10];
Random random = new Random();

for (int i = 0; i < arr.Length; i++) { arr[i] = random.Next(0, 5); }

Console.WriteLine("Изначальный массив:");
for (int i = 0; i < arr.Length; i++) {
    Console.Write(arr[i] + (i + 1 != (arr.Length) ? ", " : "\n"));
}

for (int i = 0; i < arr.Length; i++) {
    if (arr[i] <= 0) {
        arr[i] = -1;
        for (int j = i; j < arr.Length; j++) {
            if (arr[j] > 0) {
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
                break;
            }
        }
    }
}
Console.WriteLine("");

Console.WriteLine("Результат:");
for (int i = 0; i < arr.Length; i++) {
    Console.Write(arr[i] + (i + 1 != (arr.Length) ? ", " : "\n"));
}

Console.WriteLine("");
#endregion


#region Задание 2
// TASK:
//Заполнить квадратную матрицу размером N x N по спирали (N - нечётное число).
//Число 1 ставится в центр матрицы,
//а затем массив заполняется по спирали против часовой стрелки значениями по возрастанию.

// CODE:
bool isNext = true;
int n = 0;

do {
    Console.Write("Введите размер матрицы\n(знач. должно быть нечёт.): ");
    n = int.Parse(Console.ReadLine());

    isNext = !((n % 2) != 0);
    if (isNext) { Console.WriteLine("Вы ввели чётное число!\n"); }
} while (isNext);

int center = n / 2;
int count = 1;
const bool comments = false;
int size = n * n;
int right = 1, down = 1, 
    left = 1, up = 1;
int[,] matrix = new int[n, n];
matrix[center, center] = count++;
int[] lastPos = new int[2] { center, center };
if (comments)
    Console.WriteLine("Начало: " + center + " " + center);

for (int c = 1; c < size; c++) {
    // 0 - вправо, 1 - вниз, 2 - влево, 3 - вверх
    if ((c % 4) == 0) {
        for (int k = 0, r = 1, border = (n - 1); k < right && k < border && count <= size; k++) {
            int temp = lastPos[1] + r;
            left++;
            if (temp < n) {
                lastPos[1] = temp;
                matrix[lastPos[0], lastPos[1]] = count++;
            }
        }
        if (comments)
            Console.WriteLine("Вправо. Координаты: i = " + lastPos[0] + ", j = " + lastPos[1] + ". Right: " + right + ". Count: " + (count - 1) + "\n");
        right = 1;
    } else if ((c % 4) == 1) {        
        for (int k = 0, d = 1, border = (n - 1); k < down && k < border && count <= size; k++) {
            int temp = lastPos[0] + d;
            up++;
            if (temp < n) { 
                lastPos[0] = temp;
                matrix[lastPos[0], lastPos[1]] = count++;
            }
        }
        if (comments)
            Console.WriteLine("Вниз. Координаты: i = " + lastPos[0] + ", j = " + lastPos[1] + ". Down: " + down + ". Count: " + (count - 1));
        down = 1;
    } else if ((c % 4) == 2) {
        for (int k = 0, l = 1; k < left && count <= size; k++) {
            int temp = lastPos[1] - l;
            right++;
            if (temp >= 0) {
                lastPos[1] = temp;
                matrix[lastPos[0], lastPos[1]] = count++;
            }
        }
        if (comments)
            Console.WriteLine("Влево. Координаты: i = " + lastPos[0] + ", j = " + lastPos[1] + ". Left: " + left + ". Count: " + (count - 1));
        left = 1;
    } else if ((c % 4) == 3) {
        for (int k = 0, u = 1, border = (n - 1); k < up && k < border && count <= size; k++) {
            int temp = lastPos[0] - u;
            down++;
            if (temp >= 0) {
                lastPos[0] = temp;
                matrix[lastPos[0], lastPos[1]] = count++;
            }
        }
        if (comments)
            Console.WriteLine("Вверх. Координаты: i = " + lastPos[0] + ", j = " + lastPos[1] + ". Up: " + up + ". Count: " + (count - 1));
        up = 1;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine("");
}

Console.WriteLine("");
#endregion


#region Задание 3
// TASK:
//Дан двумерный массив размерностью N х М,
//заполненный случайными числами из диапазона от 0 до 100.
//Выполнить циклический сдвиг массива на заданное количество столбцов.
//Направление сдвига задаёт пользователь.

// CODE:
int m = 0;
int userChoice = 0;
int shift = 0;

do {
    Console.Write("Введите размер матрицы N = ");
    n = int.Parse(Console.ReadLine());

    isNext = !(n >= 1);
    if (isNext) { Console.WriteLine("Введите число больше 0!\n"); }
} while (isNext);

do {
    Console.Write("Введите размер матрицы M = ");
    m = int.Parse(Console.ReadLine());

    isNext = !(m >= 1);
    if (isNext) { Console.WriteLine("Введите число больше 0!\n"); }
} while (isNext);

matrix = new int[n, m];

for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        matrix[i, j] = random.Next(0, 100);
    }
}
Console.WriteLine("");

Console.WriteLine("Изначальный массив:");
for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine("");
}
Console.WriteLine("");

do {
    Console.Write("Введите по какому направление хотите сделать свдиг:\n1. По горизонтали\n2. По вертикали\nВвод: ");
    userChoice = int.Parse(Console.ReadLine());

    isNext = !(userChoice >= 1 && userChoice <= 2);
    if (isNext) { Console.WriteLine("Вы ввели неверный пункт!\n"); }
} while (isNext);

do {
    Console.Write("Введите на сколько хотите выполнить сдвиг массива: ");
    shift = int.Parse(Console.ReadLine());

    isNext = !(userChoice == 1 ? shift <= m && shift > 0 : shift <= n && shift > 0);
    if (isNext) { Console.WriteLine("Вы ввели значение, выходящее за диапозон или меньше 0!\n"); }
} while (isNext);

if (userChoice == 1) {
    int[,] tempMatrix = new int[n, shift];

    for (int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < shift; j++) {
            tempMatrix[i, j] = matrix[i, j];
            matrix[i, j] = 0;
        }
    }

    if (comments) {
        Console.WriteLine("Массив с 0:");
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }

    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (matrix[i, j] == 0) {
                for(int k = j; k < matrix.GetLength(1); k++) {
                    if (matrix[i, k] > 0) {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[i, j];
                        matrix[i, j] = temp;
                        break;
                    }
                }
            }
        }
    }

    if (comments) {
        Console.WriteLine("Массив с смещением 0:");
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");

        Console.WriteLine("tempMatrix массив:");
        for (int i = 0; i < tempMatrix.GetLength(0); i++) {
            for (int j = 0; j < tempMatrix.GetLength(1); j++) {
                Console.Write(tempMatrix[i, j] + "\t");
            }
            Console.WriteLine("");
        }
    }
    Console.WriteLine("");

    for (int i = 0, iTemp = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0, jTemp = 0; j < matrix.GetLength(1); j++) {
            if (matrix[i, j] == 0) {
                matrix[i, j] = tempMatrix[iTemp, jTemp++];
            }
        }
        iTemp++;
    }
} else {
    int[,] tempMatrix = new int[shift, m];

    for (int i = 0; i < shift; i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            tempMatrix[i, j] = matrix[i, j];
            matrix[i, j] = 0;
        }
    }

    if (comments) {
        Console.WriteLine("Массив с 0:");
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }

    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (matrix[i, j] == 0) {
                for (int k = i; k < matrix.GetLength(0); k++) {
                    if (matrix[k, j] > 0) {
                        int temp = matrix[k, j];
                        matrix[k, j] = matrix[i, j];
                        matrix[i, j] = temp;
                        break;
                    }
                }
            }
        }
    }

    if (comments) {
        Console.WriteLine("Массив с смещением 0:");
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");

        Console.WriteLine("tempMatrix массив:");
        for (int i = 0; i < tempMatrix.GetLength(0); i++) {
            for (int j = 0; j < tempMatrix.GetLength(1); j++) {
                Console.Write(tempMatrix[i, j] + "\t");
            }
            Console.WriteLine("");
        }
    }
    Console.WriteLine("");

    for (int i = 0, iTemp = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0, jTemp = 0; j < matrix.GetLength(1); j++) {
            if (matrix[i, j] == 0) {
                matrix[i, j] = tempMatrix[iTemp, jTemp++];

                if ((j + 1) == matrix.GetLength(1)) {
                    iTemp++;
                }
            }
        }
    }
}

Console.WriteLine("Результат:");
for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine("");
}
Console.WriteLine("");
#endregion