//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Напишите одно число");
int a = int.Parse(Console.ReadLine()!);
int b = 2;
while (a>=b)
{
    Console.WriteLine(b);
    b+=2;
}