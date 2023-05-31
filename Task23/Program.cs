//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int number = Prompt("Введите число: ");
PrintDegreTable(number);

int Prompt(String message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()); ;
}

void PrintDegreTable(int number)
{
for (int i = 2; i <= number; i++)
{
Console.Write(Math.Pow(i, 3) + " ");
}
}