// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int Raz (int [] arr)
{
  int max = arr[0];
  int min = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > max)
    {
      max = arr[i];
    }
    if(arr[i] < min)
    {
      min = arr[i];
    }
  }
  int x = max - min;
  return x;
}
int size = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
int [] arr = EightMass(size, from, to);
Print(arr);
Console.WriteLine(Raz(arr));