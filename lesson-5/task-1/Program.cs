// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] Array = new int[] { 345, 897, 568, 234 };

bool IsEven(int Value)
{
    return Value % 2 == 0;
}

int GetEvalCount(int[] NumberArray)
{
    int EvanlIntCount = 0;

    for (int i = 0; i < NumberArray.Length; i++)
    {
        if (IsEven(NumberArray[i])) EvanlIntCount++;
    }

    return EvanlIntCount;
}

Console.WriteLine(GetEvalCount(Array));