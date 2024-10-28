using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal interface ICalc {
    int Less(int valueToComputer);
    int Greater(int valueToComputer);
}

internal interface ICalc2 : ICalc {
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

internal interface IOutput : ICalc2 {
    void Output();
}

internal interface IOutput2 : IOutput {
    void ShowEven();
    void ShowOdd();
}

internal class Array : IOutput2 {
    int[] arr;

    public Array() : this(10) { }
    public Array(int size) { arr = new int[size]; }
    public Array(params int[] arr) {
        this.arr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) { this.arr[i] = arr[i]; }
    }

    public void Output() {
        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + (i != (arr.Length - 1) ? ", " : "\n"));
        }
    }

    public void Add(int element) {
        int[] tempArr = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++) { tempArr[i] = arr[i]; }

        tempArr[arr.Length] = element;
        arr = tempArr;
    }

    public void Del(int element) {
        int index = GetIndexElement(element);
        if (index == -1) { Console.WriteLine("Такого элемента нет!"); return; }

        int[] tempArr = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++) {
            if (i != index) { tempArr[j++] = arr[i]; }
        }

        arr = tempArr;
    }

    public int GetIndexElement(int element) {
        int index = -1;

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == element) { return i; }
        }

        return index;
    }

    public int Less(int valueToComputer) {
        int count = 0;

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] < valueToComputer) { count++; }
        }

        return count;
    }
    public int Greater(int valueToComputer) {
        int count = 0;

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > valueToComputer) { count++; }
        }

        return count;
    }

    public void ShowEven() {
        int count = 0;

        for (int i = 0; i < arr.Length; i++) {
            if ((arr[i] % 2) == 0) { count++; }
        }

        Console.WriteLine($"Кол-во чётнных: {count}");
    }
    public void ShowOdd() {
        int count = 0;

        for (int i = 0; i < arr.Length; i++) {
            if ((arr[i] % 2) != 0) { count++; }
        }

        Console.WriteLine($"Кол-во нечётнных: {count}");
    }

    public int CountDistinct() {
        int count = 0;

        for (int i = 0; i < arr.Length; i++) {
            bool isUnique = true;

            for (int j = 0; j < i; j++) {
                if (arr[i] == arr[j]) {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique) { count++; }
        }

        return count;
    }
    public int EqualToValue(int valueToCompare) {
        int count = 0;

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == valueToCompare) { count++; }
        }

        return count;
    }
}
