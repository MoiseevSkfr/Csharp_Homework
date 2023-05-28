// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите день недели: ");
int week = int.Parse(Console.ReadLine());
FindWekeendDay(week);

void FindWekeendDay(int day)
{
    if(day == 6)
    {
    Console.WriteLine("День " + day + " - это выходной день");
    }
    if(day == 7)
    {
    Console.WriteLine("День " + day + " - это выходной день");
    }
    if(day < 6)
    {
    Console.WriteLine("День " + day + " это рабочий день");
    }
    if(day > 7)
    {
    Console.WriteLine("Не существует такого дня недели");
    }
}
