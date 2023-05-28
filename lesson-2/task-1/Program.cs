// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ConvertCharToInt (char character) {
    return character - '0';
}

bool NumberHasDigitByIndex (int number,int index) {
    return number.ToString().Length >= index + 1;
}

int GetDigitByIndexFromNumber (int number,int index) {
     char secondCharacterFromNumber = number.ToString()[index];

     return ConvertCharToInt(secondCharacterFromNumber);
}

void WriteInConsoleDigitByPositionFromNumber (int number,int position) {
    if(NumberHasDigitByIndex(number,position - 1)){
        int digitByIndex = GetDigitByIndexFromNumber(number,position - 1);

        Console.WriteLine(digitByIndex);
    }
    else {
       Console.WriteLine(position + " цифры в числе нет");
    }
}

int number1 = 456;
int number2 = 782;
int number3 = 918;

int digitPosition = 2;

WriteInConsoleDigitByPositionFromNumber(number1,digitPosition);
WriteInConsoleDigitByPositionFromNumber(number2,digitPosition);
WriteInConsoleDigitByPositionFromNumber(number3,digitPosition);