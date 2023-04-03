// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] Ymn(int[,] mat1, int [,] mat2)
{
  int[,] mat3 = new int[mat1.GetLength(0),(mat2.GetLength(1))];
  for (int i = 0; i < mat1.GetLength(0); i++ )
  {
    for(int j = 0; j < mat2.GetLength(1); j++)
    {
      for(int l = 0; l < mat2.GetLength(0); l++)
      {
        mat3[i,j] += mat1[i,l] * mat2[l,j];
      }
    }
  }
  return mat3;
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass1 = MassNums(row_num, column_num, start, stop);
Print(mass1);

Console.Write("Enter the number of rows: ");
int row_num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num1 = int.Parse(Console.ReadLine()!);

int[,] mass2 = MassNums(row_num1, column_num1, start, stop);
Print(mass2);
if (row_num == column_num1)
{
  Print(Ymn(mass1,mass2));
}
else
{
  Console.WriteLine("Перемножение невозможно");
}
