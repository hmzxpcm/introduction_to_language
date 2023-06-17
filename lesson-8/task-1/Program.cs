// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array = new int[3, 4] {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

int[] GetSortedDescArray(int[] array)
{
    int[] arr = array;

    for (int j = arr.Length - 1; j > 0; j--)
    {
        for (int i = 0; i < j; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
    }

    return arr;
}

void PrintSortedDesc2DArray(int[,] array)
{
    int rowsCount = array.GetLength(0);
    int colsCount = array.GetLength(1);

    for (int i = 0; i < rowsCount; i++)
    {
        int[] arrayToSorted = new int[colsCount];

        for (int j = 0; j < colsCount; j++)
        {
            arrayToSorted[j] = array[i, j];
        }
        PrintArray(
            GetSortedDescArray(
                arrayToSorted
            )
        );

        Console.WriteLine("");
    }
}

PrintSortedDesc2DArray(array);
