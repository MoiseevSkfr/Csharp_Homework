//Зад.19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void FindingMultiple(int num)
{
if (num < 100000 && num > 9999)
{
    int fiveNum = num % 10;
    int fourNum = num /10 % 10;
    int thirdNum = num /100 % 10;
    int summRight = fiveNum + fourNum + thirdNum;

    int firstNum = num / 10000;
    int secondNum = num / 1000 % 10;
    int summLeft = firstNum + secondNum + thirdNum;
    
    if(summLeft == summRight)
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }

}
else 
    {
        Console.WriteLine("Не верное число");
    }
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
FindingMultiple(number);
