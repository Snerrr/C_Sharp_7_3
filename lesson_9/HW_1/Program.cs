// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Write("Enter number M: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int num1 = int.Parse(Console.ReadLine()!);

void NaturalArr(int M, int N)
{
    if(N < M ) return;
    if (N % 2 == 0)
    {
     NaturalArr(M, N-2);
     Console.Write($"{N} ");
    }
    else
    {
      NaturalArr(M, N-1);
    }
}
NaturalArr(num, num1);