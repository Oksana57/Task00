﻿// Задача 58: Задайте две матрицы.
//  Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");

    }

}

int[,] CompositionTwoMatrix (int[,]matrixA,int[,]martixB)
{
    // int [,] matrixA = CreatMatrixRndInt(3, 2, 1, 20);
    // int [,] matrixB = CreatMatrixRndInt(2, 3, 1, 20);
    int [,] newmatrix = new int [matrixA.GetLength(0), martixB.GetLength(1)];
    for(int i =0; i<newmatrix.GetLength(0);i++)
    {
        for(int j =0;j<newmatrix.GetLength(1);j++)
        {
            newmatrix[i,j]=((matrixA[i,j]*matrixB[i,j])+(matrixA[i,j+1]*martixB[i+1.j]));
        }
    }

return newmatrix;
}

int[,] matrixA = CreatMatrixRndInt(3, 2, 1, 20);
int[,] matrixB = CreatMatrixRndInt(2, 3, 1, 20);
int[,] compositionTwoMatrix = CompositionTwoMatrix(matrixA, matrixB);

int[,] creatmatrixrndint = CreatMatrixRndInt(3, 3, 1, 20);
PrintMatrix(compositionTwoMatrix);
Console.WriteLine();


// int[,] decreasematrix = DecreaseMatrix(creatmatrixrndint);
// PrintMatrix(decreasematrix);