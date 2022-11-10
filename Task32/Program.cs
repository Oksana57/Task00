// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreteArrayRndInt(int size, int min, int max)
{
    int[]array = new int[size];
    Random rnd = new Random();
    for(int i =0; i < size; i++)
    {
        array [i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        if(i<array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

 Console.WriteLine("]");
 }

void InversArray( int [] array)
{
    for(int i=0;i<array.Length; i++)
    {
        array[i] *=-1;
    }
}

 int [] arr = CreteArrayRndInt(4, -9, 9);
 PrintArray(arr);
InversArray(arr);
PrintArray(arr);
