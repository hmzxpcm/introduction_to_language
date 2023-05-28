// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetNumberDegrees(int number, int degrees)
{
    double result = number;

    for (int i = 1; i < degrees; i++)
    {
        result = result * number;
    }

    return result;
}


void PrintNumber(int number, int degrees)
{
    if (number <= 0 || degrees <= 0)
    {
        Console.WriteLine("Число и степень должна быть больше 0");
    }
    else
    {
        Console.WriteLine(
            GetNumberDegrees(number, degrees)
        );
    }
}

PrintNumber(3, 5);
PrintNumber(2, 4);
PrintNumber(1, 1);