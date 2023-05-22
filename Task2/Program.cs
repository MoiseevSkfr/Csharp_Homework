// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите значение a");
Console.WriteLine("Введите значение b");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = a > b ? max = a : max = b;

Console.WriteLine(max);