﻿// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
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
            else Console.Write($"{matrix[i, j],5} | ");
        }
        Console.WriteLine("|");

    }

}

void ReplaceRow (int [,] matrix)
{
    for (int j =0; j<matrix.GetLength(1);j++)
    {
        int temp = matrix[0,j];
        matrix [0,j] = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j] = temp;

    }
}

int[,] creatmatrixrndint = CreatMatrixRndInt(3, 4, 1, 20);
PrintArray(creatmatrixrndint);
Console.WriteLine();

ReplaceRow(creatmatrixrndint);
PrintArray(creatmatrixrndint);