// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int[] GetPositionNumberInArray2D(int[,] array, int number)
{
    int rowsCount = array.GetLength(0);
    int colsCount = array.GetLength(1);

    int[] position = new int[2];

    for (int row = 0; row < rowsCount; row++)
    {
        for (int col = 0; col < colsCount; col++)
        {
            if (array[row, col] == number)
            {
                position[0] = row;
                position[1] = col;
            }
        }
    }

    return position;
}

bool Array2DHasNumber(int[,] array, int number)
{
    int rowsCount = array.GetLength(0);
    int colsCount = array.GetLength(1);

    for (int row = 0; row < rowsCount; row++)
    {
        for (int col = 0; col < colsCount; col++)
        {
            if (array[row, col] == number)
            {
                return true;

                break;
            }
        }
    }

    return false;
}

void PrintPosition(int[,] array, int number)
{
    if (Array2DHasNumber(array, number))
    {
        int[] position = GetPositionNumberInArray2D(array, number);
        Console.WriteLine("Позиция элемента: {" + position[0] + "," + position[1] + "}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

PrintPosition(array, 17);