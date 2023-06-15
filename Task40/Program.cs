// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int InPutNum(string message) // ввод данных
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}


void ChekTrueTriangel (int num, int num2, int num3) 
{
if (num<num2+num3 && num2<num+num3 && num3<num+num2) {
Console.WriteLine($"Такой треугольник существует");}
else Console.WriteLine($"Такой треугольник не существует");
}


int a = InPutNum("введите первую сторону");
int b = InPutNum("введите первую сторону");
int c = InPutNum("введите первую сторону");
ChekTrueTriangel (a,b,c);
