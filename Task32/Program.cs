// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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
    Console.Write("] -> ");
    return mass;
}
int [] IndMult(int[] arr)
{ 
    Console.Write("[ ");
    for (int i = 0; i< arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
    return arr;
}
int [] array = Massive(8,-8,8);
IndMult(array);



