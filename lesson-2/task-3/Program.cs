// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int [] arrayDayNumbersOfWeek = {1,2,3,4,5,6,7};
bool WeekHasDayByNumber (int dayNumber){
    return Array.IndexOf(arrayDayNumbersOfWeek,dayNumber) != -1;
};

int [] arrayDayNumbersOfWeekend = {6,7};
bool IsWeekendDay (int dayNumber) {
    return Array.IndexOf(arrayDayNumbersOfWeekend,dayNumber) != -1;
};

void PrintIsWeekend (int dayNumber){
    if(!WeekHasDayByNumber(dayNumber)) {
        Console.WriteLine("Дня недели с указанным номером не существует");

        return;
    } 

    if (IsWeekendDay(dayNumber)) {
        Console.WriteLine("Да");
    }
    else {
        Console.WriteLine("Нет");
    } 
}

PrintIsWeekend(6);
PrintIsWeekend(7);
PrintIsWeekend(1);
PrintIsWeekend(0);