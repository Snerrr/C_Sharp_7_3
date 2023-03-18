//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double Step(int a, int b)
{
  return Math.Pow(a,b);
}
Console.WriteLine("Напишите число и степень в которую его возводить");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
double x = Step(a , b);
Console.WriteLine(x);