// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int random = new Random().Next(100,1000);
Console.WriteLine(random);
void Vtoray(int a)
{
     a = a / 10;
     a = a % 10;
     Console.WriteLine(a);
}
Vtoray(random);
