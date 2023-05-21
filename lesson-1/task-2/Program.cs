// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int firstNumber =  Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber =  Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int thirdNumber =  Int32.Parse(Console.ReadLine());

int maxNumber = new int[] {firstNumber,secondNumber,thirdNumber}.Max();

Console.WriteLine(maxNumber);