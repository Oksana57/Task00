// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int [] MatrixToArray(int [,] matrix)
{
    int[]array = new int[matrix.Length];
    int k=0;
    for(int i = 0; i<matrix.GetLength(0);i++)
    {
    
    for (int j =0; j<matrix.GetLength(1);j++)
{
array [k++] = matrix[i,j];

}
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.WriteLine("]");
}

// Array.Sort(array);

void CountVocabulaty (int [] array)
{
int i = 0;
int num = array[i];
int count = 1;

while(i<array.Length)
    // for(int i = 1; i<array.Length;i++)
    {
    if(array[i]==num) count ++;
    // Console.WriteLine($"Количество чисел{num} = {count}");
    else 
    Console.WriteLine($"Количество чисел {num} = {count}");
    num = array[i]; count =1; i++;
    
    // Console.WriteLine($"Количество чисел {num} = {count}");
// num = array[i];
// count=1; 
}
// Console.WriteLine($"Количество чисел{num} = {count}");
}

int[,] creatmatrixrndint = CreatMatrixRndInt(3, 3, 1, 20);
PrintMatrix(creatmatrixrndint);
Console.WriteLine();
int [] matrixtoarray = MatrixToArray(creatmatrixrndint);
PrintArray(matrixtoarray);

Array.Sort(matrixtoarray);
PrintArray(matrixtoarray);
CountVocabulaty(matrixtoarray);

// int[] MatrixToArray(int[,] matrix)
// {
//     int[] array = new int[matrix.Length];
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[k++] = matrix[i, j];
//         }
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         {
//             if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//             else Console.Write($"{array[i]}");
//         }
//     }
//     Console.Write("] ");
// }

// void Dictionary(int[] array)
// {
//     int num = array[0];
//     int count = 1;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] == num) count++;
//         else
//         {
//             Console.WriteLine($"число {num} встречается {count} раз");
//             num = array[i];
//             count = 1;
//         }
//     }
//     Console.WriteLine($"число {num} встречается {count} раз");
// }