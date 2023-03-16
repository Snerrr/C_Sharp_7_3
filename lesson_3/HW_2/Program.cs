//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2   A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Напишите координаты двух точек");
double Distance(int xb, int xa, int yb, int ya, int zb, int za)
{
    return Math.Sqrt(Math.Pow(xb - xa,2) + Math.Pow(yb - ya,2) + Math.Pow(zb - za,2));
}
int xa = int.Parse(Console.ReadLine()!);
int ya = int.Parse(Console.ReadLine()!);
int za = int.Parse(Console.ReadLine()!);
int xb = int.Parse(Console.ReadLine()!);
int yb = int.Parse(Console.ReadLine()!);
int zb = int.Parse(Console.ReadLine()!);
Console.WriteLine(Distance(xb,xa,yb,ya,zb,za));