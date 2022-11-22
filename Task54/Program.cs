﻿// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Console.Write($"{matrix[i, j]}");
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");

    }

}

int[,] DecreaseMatrix(int[,]matrix)
{
// int [,] newmatrix = new int [CreatMatrixRndInt.Length];
int i =0;
int j =0;
int max = matrix[i, j];
for (i = 0; i < matrix.GetLength(0); i++)
    //  int max = matrix[i,j];
    {
        for  (j = 1; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]>max) matrix[i,j]=matrix[i,j-1];
            {
            // int temp = max;
            // max = matrix[i,j]; 
            // matrix[i,j] = temp;
            }
            matrix[i,j] = matrix[i,matrix.GetLength(1)-1];
            // matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] creatmatrixrndint = CreatMatrixRndInt(3, 3, 1, 20);
PrintMatrix(creatmatrixrndint);
Console.WriteLine();
int [,] decreasematrix = DecreaseMatrix(creatmatrixrndint);
PrintMatrix(decreasematrix);