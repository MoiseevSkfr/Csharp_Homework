// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int [] Massive(int size, int minValue, int maxValue)
{
    int[] mass = new int[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(minValue,maxValue +1);
        Console.Write($"{mass[i]} ");
    }
    Console.Write("]");
    return mass;
}

void FindeEvenElement (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int res = arr[i] / 2;
        if (res*2 == arr[i]) 
            {
                count += 1;
            }
    }
    Console.WriteLine(" ");
    Console.WriteLine($"Кол-во чётных элементов в массиве -> {count}");
}

int [] array = Massive(10,100,1000);
FindeEvenElement(array);
