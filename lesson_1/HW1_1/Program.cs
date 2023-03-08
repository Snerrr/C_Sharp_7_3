// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Напишите два числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.WriteLine($"Big-{a}");
    Console.WriteLine($"Small-{b}");
}
else if (b>a)
{
    Console.WriteLine($"Big-{b}");
    Console.WriteLine($"Small-{a}");
}
else
{
    Console.WriteLine("Числа равные");
}