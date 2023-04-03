// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)        
            Console.Write($" {arr[i, j]} ");        
        Console.WriteLine();       
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)      
        for (int j = 0; j < column; j++)        
            arr[i, j] = new Random().Next(from, to + 1);                
    
    return arr;
}

int[] Sum(int[,] arr)
{
  int row_size = arr.GetLength(0);
  int column_size = arr.GetLength(1);
  int[] summa = new int[row_size];
  for (int i = 0; i < row_size; i++)
  {
    int s = 0;
    for (int j = 0; j < column_size; j++) 
    {
      s += arr[i,j];
    }
    summa[i] += s;
  }
  return summa;
}

void Printt(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

void Naib(int[] arr)
{
  int min = arr[0];
  int t = 0;
  for (int i = 1; i < arr.Length; i++)
  {
    if (min > arr[i])
    {
      min = arr[i];
      t = i;
    }
  }
  Console.WriteLine($"Строка с наименьшей суммиой - {t+1}");
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);
Printt(Sum(mass));
Naib(Sum(mass));