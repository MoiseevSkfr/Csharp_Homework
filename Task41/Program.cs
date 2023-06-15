// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int i = 0;
int count = 0;
while(i<5)
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    i++;
    if (num > 0)
        {
        count += 1;
        }
}

Console.WriteLine($"Положительных чисел введено -> {count}");