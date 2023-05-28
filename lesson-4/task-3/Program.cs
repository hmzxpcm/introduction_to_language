// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random getrandom = new Random();

int[] GetRandomArray(int length, int minVal, int maxVal)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = getrandom.Next(minVal, maxVal);
    }

    return result;
}

string ConversionIntArrayToString(int[] array)
{
    return string.Join(", ", array);
}

void PrintArray(int[] array)
{
    string arrayInString = ConversionIntArrayToString(array);

    Console.WriteLine($"[{arrayInString}]");
}

PrintArray(
    GetRandomArray(8, 1, 10)
);