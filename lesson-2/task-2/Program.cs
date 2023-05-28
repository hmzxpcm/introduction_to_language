// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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

int number1 = 645;
int number2 = 78;
int number3 = 32679;

int digitPosition = 3;

WriteInConsoleDigitByPositionFromNumber(number1,digitPosition);
WriteInConsoleDigitByPositionFromNumber(number2,digitPosition);
WriteInConsoleDigitByPositionFromNumber(number3,digitPosition);