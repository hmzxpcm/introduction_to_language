// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = new int[2, 2] {
    {2,4},
    {3,2}
};

int[,] matrix2 = new int[2, 2] {
    {3,4},
    {3,3}
};

int[,] PowMatrix(int[,] martix1, int[,] matrix2)
{
    int[,] result = new int[2, 2];


    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    int colsCount = matrix.GetLength(1);
    int rowsCount = matrix.GetLength(0);

    for (int row = 0; row < rowsCount; row++)
    {
        for (int col = 0; col < colsCount; col++)
        {
            Console.Write(matrix[row, col]);

            if (col + 1 != colsCount) Console.Write(", ");
        }
        Console.WriteLine("");
    }
}

PrintMatrix(
    PowMatrix(
        matrix1, matrix2
    )
);