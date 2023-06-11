// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Random rand = new Random();

double[,] Get2DArray(int row, int column)
{
    double[,] array = new double[row, column];

    for (int r = 0; r < row; r++)
    {
        for (int c = 0; c < column; c++)
        {
            array[r, c] = Math.Round(rand.Next(-100, 100) + rand.NextDouble(), 1);
        }
    }

    return array;
}

void Print2DArray(double[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int r = 0; r < row; r++)
    {
        for (int c = 0; c < col; c++)
        {
            Console.Write(array[r, c]);

            if (c + 1 != col) Console.Write(", ");
        }

        Console.WriteLine("");
    }
}


Print2DArray(
    Get2DArray(3, 4)
);