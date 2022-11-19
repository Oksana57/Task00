// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
            else Console.Write($"{matrix[i, j],5} | ");
        }
        Console.WriteLine("|");
    }

}

double AritmeticMeanMatrix(int[,] matrix)
{
    double sumJ = 0;
    double result = 0;
    // double[]array = new double(matrix.GetLength(1));
    // while (j< matrix.GetLength(1))

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        while (j < matrix.GetLength(1))
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // while (j < matrix.GetLength(1))
                {
                    sumJ = sumJ + matrix[i, j];
                }
                sumJ = sumJ / 2;
                result = Math.Round(sumJ, 1);
            }
            Console.WriteLine($"{result}");
    }
    
}
// return new double[] {result};
}


Console.WriteLine("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max");
int max = Convert.ToInt32(Console.ReadLine());

int[,] creatmatrixrndint = CreatMatrixRndInt(m, n, min, max);
PrintArray(creatmatrixrndint);

double aritmeticMeanMatrix = AritmeticMeanMatrix(creatmatrixrndint);