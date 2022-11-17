// /Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} ");
        else Console.Write($"{matrix[i,j], 5} | ");
        }
Console.WriteLine("|");
        // if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        // else Console.Write($"{array[i]}");
    }

}

void ReplaceEvebIndexMatrix(int [,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            
            matrix[i,j] = matrix[i,j]*matrix[i,j];
}
    }
}
int[,] creatmatrixrndint = CreatMatrixRndInt(3,4,-10,10);
PrintArray(creatmatrixrndint);
Console.WriteLine();
ReplaceEvebIndexMatrix(creatmatrixrndint);
PrintArray(creatmatrixrndint);
