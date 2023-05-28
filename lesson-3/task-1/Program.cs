// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// P.S. Число является палиндромом, если оно читается одинаково как слева направо, так и справа налево.

string ReverseString(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

bool NumberIsPalindrome(int number)
{
    string numberInString = number.ToString();

    string reverseNumberInString = ReverseString(numberInString);

    return numberInString == reverseNumberInString;
}

void PrintNumberIsPalindrome(int number)
{
    string valueToPrint = NumberIsPalindrome(number) ? "да" : "нет";

    Console.WriteLine(valueToPrint);
}

PrintNumberIsPalindrome(14212);
PrintNumberIsPalindrome(12821);
PrintNumberIsPalindrome(23432);