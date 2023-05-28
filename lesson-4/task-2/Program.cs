// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ConversionCharToInt(char character)
{
    return character - '0';
}

int[] GetArrayDigitFromNumber(int number)
{
    string numberInString = number.ToString();
    int[] result = new int[numberInString.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = ConversionCharToInt(numberInString[i]);
    }

    return result;
}

int GetSumAllDigitFromNumber(int number)
{
    int[] arrayDigitFromNumber = GetArrayDigitFromNumber(number);

    int result = 0;

    for (int i = 0; i < arrayDigitFromNumber.Length; i++)
    {
        result = result + arrayDigitFromNumber[i];

    }

    return result;
}

void PrintSumAllDigitFromNumber(int number)
{
    if (number <= 0)
    {
        Console.WriteLine("Число должно быть больше 0");
    }
    else
    {
        Console.WriteLine(GetSumAllDigitFromNumber(number));
    }
}

PrintSumAllDigitFromNumber(452);
PrintSumAllDigitFromNumber(82);
PrintSumAllDigitFromNumber(9012);
PrintSumAllDigitFromNumber(0);