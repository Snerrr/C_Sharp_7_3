// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int Kol(int [] arr)
{
  int k = 0;
  for (int i = 0; i < arr.Length; i++ )
  {
    if ( arr[i] % 2 == 0)
    {
      k += 1;
    }
  }
  return k;
}
int size = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
int [] arr = EightMass(size, from, to);
Print(arr);
Console.WriteLine(Kol(arr));
