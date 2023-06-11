// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

double[] GetAverageNumberFromArrayColumns(int[,] array)
{
    int rowsCount = array.GetLength(0);
    int columnsCount = array.GetLength(1);

    double[] result = new double[columnsCount];

    for (int col = 0; col < columnsCount; col++)
    {
        int sum = 0;

        for (int row = 0; row < rowsCount; row++)
        {
            sum = sum + array[row, col];
        }

        double average = (double)sum / rowsCount;

        result[col] = average;
    }

    return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 1));

        if (i + 1 != array.Length) Console.Write(", ");
    }
}

PrintArray(
    GetAverageNumberFromArrayColumns(array)
);