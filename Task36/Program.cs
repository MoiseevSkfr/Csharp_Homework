//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

void FindeSumElement (int [] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length;)
    {
        sum += arr[i];
        i += 2;
    }
    Console.WriteLine(" ");
    Console.WriteLine($"Сумма элементов на нечётной позиции = {sum}");
}

int [] array = Massive(10,-100,1000);
FindeSumElement(array);