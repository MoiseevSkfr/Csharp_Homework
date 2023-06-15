// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//int InPutNum(string message) // ввод данных
//{
  //  Console.WriteLine(message);
    //return Convert.ToInt32(Console.ReadLine());
//}

//int a = InPutNum("Введите число");
//int res = 0;
//string showresult = string.Empty;
//while (a > 0)
//{
  //  res = a % 2;
    //a /= 2;
    //showresult = res + showresult;
//}
//Console.WriteLine();
//Console.WriteLine(showresult);

int Reader()
{
Console.WriteLine("enter your number: ");
if (int.TryParse(Console.ReadLine(), out int num) == false || num < 0)
{
num = -1;
return num;
}
else
{
return num;
}
}

int CountDifiner(int num)
{
int count = 0;
while (num != 0)
{
num = num / 2;
count++;
}
return count;
}

int[] BinaryNumConverter(int num, int count)
{
int[] binaryNum = new int[count];
for (int i = count - 1; i >= 0; i--)
{
int temp = num % 2;
num /= 2;
binaryNum[i] = temp;
}
return binaryNum;
}

void PrintBinary(int[] binary)
{
for (int i = 0; i < binary.Length; i++)
{
Console.Write(binary[i]);
}
}

int num = Reader();
switch (num)
{
case -1:
Console.WriteLine("invalid number format");
break;
default:
int count = CountDifiner(num);
PrintBinary(BinaryNumConverter(num, count));
break;
}

//Решение с разворотом массива
//int Input()
//{
//Console.Write("Введите: ");
//int number = Convert.ToInt32(Console.ReadLine());
//return number;
//}
//int[] Solution(int num)
//{
//int[] res = new int[] {};
//int i = 0;
//while (num > 0)
//{
//Array.Resize(ref res, res.Length + 1);
//res[i] = num % 2;
//num = num /2;
//i++;
//}
//return res;
//}
//int[] ReverseArray2(int[] inArray)
//{
//int[] res = new int[inArray.Length];
//for (int i = 0; i < inArray.Length; i++)
//{
//res[i] = inArray[inArray.Length - 1 - i];
//Console.Write($"{res[i]}");
//}
//return res;
//}
//int num1 = Input();
//int[] newArray = Solution(num1);
//ReverseArray2(newArray);
