// Напишите программу программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int x = 0;
int random = new Random().Next(100,1000);
Console.WriteLine(random);
int per(int a)
{
    a = a / 100;
    a = a * 10;
    return a;
}
int tre(int a)
{
    a = a % 10;
    return a;
}
x = per(random) + tre(random);
Console.WriteLine(x);
