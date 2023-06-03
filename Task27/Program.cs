// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
int number = new Random().Next(0,999999999);
int FindeSumDigit(int num)
{
    int res = 0;
    while (num > 0)
        {
        res += num % 10;
        num = num / 10;
        } 
    return res;
}

Console.Write($"Сумма всех чисел {number} = {FindeSumDigit(number)}");
