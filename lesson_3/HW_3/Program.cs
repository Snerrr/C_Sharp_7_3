//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Напишите число");
int x = int.Parse(Console.ReadLine()!);
void Kub(int a)
{
    int i = 1;
    while (i<=a)
    {
        Console.WriteLine($"Для числа {a} таблица кубов следующая: {i*i*i}");
        i++;
    }
}
Kub(x);
