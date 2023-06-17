// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    int colsCount = array.GetLength(1);
    int rowsCount = array.GetLength(0);

    for (int row = 0; row < rowsCount; row++)
    {
        for (int col = 0; col < colsCount; col++)
        {

            int number = array[row, col];
            Console.Write(
                number < 10
                ? $"0{number}"
                : number
            );

            if (col + 1 != colsCount) Console.Write(", ");
        }
        Console.WriteLine("");
    }
}

int[,] CreateArray(int size)
{
    return new int[size, size];
}

int[,] FillArraySpiral(int[,] array)
{
    int colsCount = array.GetLength(1);
    int rowsCount = array.GetLength(0);

    int step = 1;

    int rowStart = 0, rowEnd = rowsCount - 1;
    int colStart = 0, colEnd = colsCount - 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = step++;
        }

        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = step++;
        }

        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = step++;
            }

            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = step++;
            }

            colStart++;
        }
    }


    return array;
}

PrintArray(
    FillArraySpiral(
        CreateArray(4)
    )
);
