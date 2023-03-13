 //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 int random = new Random().Next(1,8);
 Console.WriteLine(random);
void Day(int a)
{
    if (a<6)
    {
        Console.WriteLine("Не выходной день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}
Day(random);
