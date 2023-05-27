//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void FindeThirdGigit(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
   
    if(number < 1000)
    if(number > 99)
    {
        int result = number / 10;
        Console.WriteLine("Третья цифра: " + result % 10);

    
    }

    if(number > 9999)
    if(number < 100000)
    {
        int result = number / 100;
        Console.WriteLine("Третья цифра: " + result % 10);
    }
}

Console.WriteLine("введите число:");
int num = int.Parse(Console.ReadLine());
FindeThirdGigit(num);
