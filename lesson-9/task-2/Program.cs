// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int startNumber, int endNumber)
{
    int result = 0;

    if (startNumber <= endNumber)
    {
        result = startNumber + GetSum(startNumber + 1, endNumber);
    }

    return result;
}

Console.WriteLine(
    GetSum(1, 15)
);

Console.WriteLine(
    GetSum(4, 8)
);



