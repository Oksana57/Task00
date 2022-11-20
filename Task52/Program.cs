﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }

}

double[] AritmeticMeanMatrix(int[,] matrix)
{
    // int sumJ = 0;
    // double result = 0;
    double[] array = new double[matrix.GetLength(1)];
    int x = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sumJ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumJ = sumJ + matrix[i, j];
        }
        double result = sumJ / matrix.GetLength(0);
        array[x] = Math.Round(result, 1);
        x++;
    }

    return array;
}

void PrintArr(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


int[,] creatmatrixrndint = CreatMatrixRndInt(3, 4, 1, 10);
PrintArray(creatmatrixrndint);
Console.WriteLine();
double[] aritmeticMeanMatrix = AritmeticMeanMatrix(creatmatrixrndint);
// PrintArr(aritmeticMeanMatrix);
Console.Write($"Среднеарифметическое по столбцам = "); PrintArr(aritmeticMeanMatrix);