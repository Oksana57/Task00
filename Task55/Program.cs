// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");

    }

}

void ReplaceRowColumn (int [,] matrix)
{
   if(matrix.GetLength(0)==matrix.GetLength(1))

    for(int i = 0; i<matrix.GetLength(0);i++)
    {
    
    for (int j =i; j<matrix.GetLength(1);j++)
    {
        int temp = matrix[i,j];
        matrix [i,j] = matrix[j,i];
        matrix[j,i] = temp;
            
    }
}
else Console.WriteLine("Обмен не возможен");
}
int[,] creatmatrixrndint = CreatMatrixRndInt(4, 4, 1, 20);
PrintArray(creatmatrixrndint);
Console.WriteLine();

ReplaceRowColumn(creatmatrixrndint);
PrintArray(creatmatrixrndint);