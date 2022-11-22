// // 
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int [] SumRowMatrix(int[,] matrix)
{
    
    int [] array = new int[matrix.GetLength(0)];
    int x = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)

        {
            sum = sum + matrix[i, j];
        }
        array[x] = sum;
        x++;
    }

    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void MinSumRow (int [] array)
{
    int min = array[0];
    int index = 1;
    // int i = 0;
    for(int i = 1; i<array.Length; i++)
    {
        if(array[i]<min) 
    {
        min = array[i]; 
        index = i+1;
    }
    }
    Console.WriteLine($"Минимальную сумму элементов содержит строка {index}");
}


int[,] creatmatrixrndint = CreatMatrixRndInt(3, 4, 1, 10);
PrintArray(creatmatrixrndint);
Console.WriteLine();
int [] sumrowmatrix = SumRowMatrix(creatmatrixrndint);
PrintArr(sumrowmatrix);
MinSumRow(sumrowmatrix);