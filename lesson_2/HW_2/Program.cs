//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int random = new Random().Next(100,1000000);
Console.WriteLine(random);
void troe(int a)
{
    if (a<100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (a>999)
        {
            a = a / 10;
        }
        a = a % 10;
        Console.WriteLine(a);
    }
}
troe(random);