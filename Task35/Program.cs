//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

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

void FindAmountElements(int[]arr)
{
    int i = 0;
    int count = 0;
    foreach(int el in arr)
    {
        if(el >= 10 && el <= 99)
        {
            count += 1;
        }
    }
    Console.WriteLine(" ");   
    Console.WriteLine($"Кол-во элементов между 10 и 99 в массиве: {count}");
}
int []array = Massive(123,1,200);
FindAmountElements(array);