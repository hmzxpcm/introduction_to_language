// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int inputMaxInteger =  Int32.Parse(Console.ReadLine());

int[] rangeIntegerArray = Enumerable.Range(1, inputMaxInteger).ToArray();

int[] evenIntegerArray = rangeIntegerArray.Where(item=> item % 2 == 0).ToArray();

Console.WriteLine(string.Join(", ", evenIntegerArray));    