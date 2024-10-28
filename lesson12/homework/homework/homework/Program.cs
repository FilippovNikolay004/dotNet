Array array = new Array(1, 5, 1, 6, 7, 1, 5, 2, 2, 7, 8);
array.Output();

array.Add(7);
array.Output();

array.Del(7);
array.Output();

Console.WriteLine($"Index: {array.GetIndexElement(3)}");

Console.WriteLine($"Less: {array.Less(4)}");
Console.WriteLine($"Greater: {array.Greater(4)}");

array.ShowEven();
array.ShowOdd();

Console.WriteLine($"Кол-во уникальных элементов: {array.CountDistinct()}");
Console.WriteLine($"Кол-во EqualToValue элементов: {array.EqualToValue(1)}");