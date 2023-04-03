// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random(); // var когда в правой части ясно какой тип данных мы используем
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }

        }
    }
    Console.WriteLine($"{indexRow} -- {indexColumn} === {min}");
    return new int[] { indexRow, indexRow };
}

int[,] DeleteMinCrossRowColumn(int[,] matrix, int removeRow, int removeColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == removeRow) continue;
        else
        {
            int l = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == removeColumn) continue;
                else
                {
                    newMatrix[k, l] = matrix[i, j];
                    l++;
                }
            }
            k++;
        }
    }
    return newMatrix;
}

int row = 5;
int column = 5;

int[,] array2D = CreateMatrixRndInt(row, column, -9, 9);
PrintMatrix(array2D);
int[] ffff = IndexMinVal(array2D);

int[,] dddd = DeleteMinCrossRowColumn(array2D, ffff[0], ffff[1]);

PrintMatrix(dddd);