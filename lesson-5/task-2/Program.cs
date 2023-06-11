// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] Array1 = { 3, 7, 23, 12 };
int[] Array2 = { -4, -6, 89, 6 };

bool IsEven(int Value)
{
    return Value % 2 == 0;
}

int GetSumNumbersWithEvenIndex(int[] Array)
{
    int result = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (IsEven(i + 1)) result = result + Array[i];
    }

    return result;
}

Console.WriteLine(GetSumNumbersWithEvenIndex(Array1));
Console.WriteLine(GetSumNumbersWithEvenIndex(Array2));