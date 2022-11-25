// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


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

int[] MinElementIndexRowColumn(int[,] matr)
{
    int min = matr[0,0];
    int[] indexes = new int[2];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]< min)
            {   
                min = matr[i,j];
                indexes[0] = i;
                indexes[1] = j;
            } 
        }
    }
    return indexes;
}

int[,] CreateNewMatrix(int[,] matr, int[] ind)
{
    int[,] newMatr = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
    int row = 0;
    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        if (row == ind[0]) row++; 
        int column = 0;
        for (int j = 0; j < newMatr.GetLength(1); j++)
        {
            if (column == ind[1]) column++; 
            newMatr[i, j] = matr[row,column];
            column++;
        }
        row++;
    }
    return newMatr;
}

int[,] matrixB = CreatMatrixRndInt(5, 5, 1, 20);
PrintMatrix(matrixB);
Console.WriteLine();
int [] minelemrowcolm = MinElementIndexRowColumn(matrixB);
int[,] newmatrix = CreateNewMatrix(matrixB, minelemrowcolm);
PrintMatrix(newmatrix);
