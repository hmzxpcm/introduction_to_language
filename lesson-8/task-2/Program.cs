// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[4, 4] {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7},
};

int GetIndexRowMinSum(int[,] array)
{
    int rowsCount = array.GetLength(0);
    int colsCount = array.GetLength(1);

    int minRowSum = 0;
    int minRowSumIndex = 0;

    for (int row = 0; row < rowsCount; row++)
    {
        int rowSum = 0;
        for (int col = 0; col < colsCount; col++)
        {
            rowSum = rowSum + array[row, col];
        }


        if (rowSum < minRowSum | minRowSum == 0)
        {
            minRowSumIndex = row;
            minRowSum = rowSum;
        }

    }

    return minRowSumIndex;
}


Console.Write(
    GetIndexRowMinSum(array) + 1
);
