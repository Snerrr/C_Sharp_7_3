// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] EightMass(int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().NextDouble()* (to - from) + from;
    return arr;
}

double Raz (double [] arr)
{
  double max = arr[0];
  double min = arr[0];
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
  Console.WriteLine($"Максимальное-{max}");
  Console.WriteLine($"Минимальное-{min}");
  double x = max - min;
  return x;
}
int size = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
double [] arr = EightMass(size, from, to);
Print(arr);
Console.WriteLine(Raz(arr));