// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        bool isLastElement = i + 1 == array.Length;

        if (!isLastElement)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }

    }
}

double[] GetNumberCubesList(int listRange)
{
    double[] list = new double[listRange];

    for (int i = 0; i < listRange; i++)
    {
        list[i] = Math.Pow(i + 1, 3);
    }

    return list;
}

PrintArray(GetNumberCubesList(3));
Console.WriteLine("");
PrintArray(GetNumberCubesList(5));
