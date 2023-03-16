//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Напишите пятизначное число");
int x = int.Parse(Console.ReadLine()!);
int Perv(int a)
{
    a = a / 1000;
    int b = a / 10;
    int c = a % 10;
    int s = b * 10 + c;
    return s;
}
int s = Perv(x);
int Pos(int a)
{
    int b = a % 10;
    int c = (a / 10) % 10;
    int s = b * 10 + c;
    return s;
}
int k = Pos(x);
if (s == k)
{
    Console.WriteLine("Число является палиндромом");
} 
else
{
    Console.WriteLine("Число НЕ является палиндромом");
}