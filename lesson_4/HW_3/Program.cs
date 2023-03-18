// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void Mas(int len)
{
  int [] massiv = new int [len]; 
  for (int i = 0; i < len; i++)
  {
    massiv[i] = new Random().Next(1,100);
    Console.Write($"{massiv[i]},");
  }
}
Console.WriteLine("Напишите длину массива");
int len = int.Parse(Console.ReadLine()!);
Mas(len);

