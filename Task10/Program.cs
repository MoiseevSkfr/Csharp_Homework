//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

void FindAverageDigit(int number)
{
    int first_secondDigit = number  / 10;
    Console.WriteLine("Вторая цифра числа: " + first_secondDigit % 10);
} 

int num = new Random().Next(99,1000);
Console.WriteLine("Рандомное число: "+num);
FindAverageDigit(num);

int num1 = new Random().Next(300,700);
Console.WriteLine("Рандомное число: "+num1);
FindAverageDigit(num1);

int num2 = new Random().Next(900,1000);
Console.WriteLine("Рандомное число: "+num2);
FindAverageDigit(num2);