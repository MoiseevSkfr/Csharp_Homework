//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();

Console.WriteLine("Ведите 8 чисел:");


int [] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("");
    array[i] = int.Parse(Console.ReadLine());   
}


void PrintArray(int[]array1)
{
Console.Write("[");
for (int i = 0; i <array1.Length -1; i++)
{
    Console.Write($"{array1[i]}, ");
}
Console.Write($"{array1[array1.Length -1]}");
Console.Write("]");
}

PrintArray(array);