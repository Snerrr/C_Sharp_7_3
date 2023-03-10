// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

void Del(int a)
{
    Console.WriteLine(a);
    if (a%7==0 & a%23==0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
    
}
int random = new Random().Next(1,1000);
Del (random);