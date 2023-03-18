// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Sum(int a)
{
  int summa = 0;
  while (a >=1)
  {
    summa += a % 10;
    a = a / 10;
  }
  return summa;
}
Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine()!);
int summa = Sum(a);
Console.WriteLine($"Сумма цифр:{summa}");