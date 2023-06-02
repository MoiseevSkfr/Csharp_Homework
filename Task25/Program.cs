//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int A = Prompt("Введите число A: ");
int B = Prompt("Введите число B: ");
CalcDigitDegree(A,B);

int Prompt(String message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!); ;
}

void CalcDigitDegree(int num,int num1)
{
double result = Math.Pow(num,num1);
Console.WriteLine($"{num} в степени {num1} = {result}");
}

