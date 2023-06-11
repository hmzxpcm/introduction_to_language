// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] array1 = new int[] { 0, 7, 8, -2, -2 };
int[] array2 = new int[] { 1, -7, 567, 89, 223 };


int GetCountNumbersGreaterZeroFromArray(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }

    return result;
}

Console.WriteLine(GetCountNumbersGreaterZeroFromArray(array1));
Console.WriteLine(GetCountNumbersGreaterZeroFromArray(array2));