// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Console.Write($"{matrix[i, j]}");
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5} | ");
        }
        Console.WriteLine("|");
        // if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        // else Console.Write($"{array[i]}");
    }

}

int SumIndexDiagonal(int[,] matrix)
{
    int length = matrix.GetLength(0) < matrix.GetLength(1)? matrix.GetLength(0):matrix.GetLength(1);
int sum = 0;
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
    {
        if (i == j) sum = sum + matrix[i, j];
    }
}
return sum;
}

int[,] creatmatrixrndint = CreatMatrixRndInt(3, 4, -10, 10);
PrintArray(creatmatrixrndint);
Console.WriteLine();
int sumIndexDiagonal = SumIndexDiagonal(creatmatrixrndint);
Console.WriteLine(sumIndexDiagonal);

