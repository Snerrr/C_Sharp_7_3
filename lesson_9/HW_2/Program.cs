// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Enter number M: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int num1 = int.Parse(Console.ReadLine()!);

int NaturalArr(int m, int n)
{
    if (n < m || n <= 0)
    {
      return 0;
    }
    else 
    {
      return NaturalArr(m, n - 1) + n;
    }
}

int x = NaturalArr(num, num1);
Console.WriteLine();
Console.WriteLine(x);