// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] firstLineData = new int[] { 2, 5 };
int[] secondLineData = new int[] { 4, 9 };

int[] GetIntersectionCoordinatesOfTwoLines(int[] firstLineData, int[] secondLineData)
{
    int m1 = firstLineData[0];
    int b1 = firstLineData[1];
    int m2 = secondLineData[0];
    int b2 = secondLineData[1];

    int x = (m2 - m1) / (b1 - b2);
    int y = b1 * x + m1;

    return new int[] { x, y };
}

void PrintCoordinates(int[] coordinates)
{
    Console.WriteLine("Точка пересечения: (" + coordinates[0] + "; " + coordinates[1] + ")");
}

PrintCoordinates(
    GetIntersectionCoordinatesOfTwoLines(
        firstLineData,
        secondLineData
    )
);