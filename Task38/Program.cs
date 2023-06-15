//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

int[] Massive(int size, int minValue, int maxValue)
{
    int[] mass = new int[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{mass[i]} ");
    }
    Console.Write("]");
    return mass;
}

void FindeSumElement(int[] arr)
{
    int i = 1;
    int max = arr[i];
    int min = 0;
    while (i < arr.Length)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else
        {
            min = arr[0];
        }
        if (min > arr[i])
        {
            min = arr[i];
        }
        i++;

    }
    Console.WriteLine(" ");
    Console.WriteLine($"Разница между максимальным и минимальным элементом = {max - min}");
}

//Метод с вещественными числами.

int[] array = Massive(10, 100, 1000);
FindeSumElement(array);

double[] Massive(int size)
{
    double[] mass = new double[size];
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        mass[i] = Math.Round(new Random().NextDouble() * 10 - 5, 2);
        Console.Write($"{mass[i]} ");
    }
    Console.Write("]");
    return mass;
}

void FindeSumElement(double[] arr)
{
    int i = 1;
    double max = arr[0];
    double min = arr[0];
    while (i < arr.Length)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        if (min > arr[i])
        {
            min = arr[i];
        }
        i++;

    }
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементом = {max - min}");
}

double[] array = Massive(10);
FindeSumElement(array);
