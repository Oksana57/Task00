// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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



void MiningIndexMatrix(int[,] matrix)
{
    Console.WriteLine("Введите строку позиции элемента");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец позиции элемента");
    int b = Convert.ToInt32(Console.ReadLine());
    if(a>matrix.GetLength(0)||b>matrix.GetLength(1)) Console.WriteLine("Такого элемента в массиве нет");
else
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            if (a == i && b == j) Console.WriteLine($"Значение элемента = {matrix[i, j]}");
            
        }

    }
}


int[,] creatmatrixrndint = CreatMatrixRndInt(3, 4, 1, 20);
PrintArray(creatmatrixrndint);
Console.WriteLine();

MiningIndexMatrix(creatmatrixrndint);
