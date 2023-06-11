// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3.0 7.0 22.5 2.0 78] -> 76

double[] Array = new double[] { 3.0, 7.0, 22.5, 2.0, 78 };

double GetDiffBetweenFirstAndLastElementArray(double[] Array)
{
    double Max = Array[0];
    double Min = Array[0];

    foreach (double Num in Array)
    {
        if (Num > Max)
        {
            Max = Num;
        }
        if (Num < Min)
        {
            Min = Num;
        }
    }

    double diff = Max - Min;

    return diff;
}

Console.WriteLine(
    GetDiffBetweenFirstAndLastElementArray(Array)
);
