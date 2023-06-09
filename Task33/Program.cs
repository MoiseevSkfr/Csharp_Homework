// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("Массив [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

void FindeNum(int[]array)
{
    Console.WriteLine();
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    bool flag = false;
    int i = 0;
    while (i < array.Length)
    {   if(array[i] == num)
        {
            flag = true;
        }
        i++;
    }
    if(flag)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
int[] massive = GetArray(12,1,1000);
PrintArray(massive);
FindeNum(massive);