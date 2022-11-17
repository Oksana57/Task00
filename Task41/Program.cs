﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int [] InputDigit(int m)
{
    Console.WriteLine("Введите количество чисел М");
    int size = Convert.ToInt32(Console.ReadLine());
    int[]array = new int [size];
    for(int i=0; i<size;i++)
    {
        Console.WriteLine("Введите число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int PositivDigit(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count ++;

    }
    return count;
}

int [] inputdigit = InputDigit(5 );
PrintArray(inputdigit);
int positivDigit = PositivDigit(inputdigit);
Console.WriteLine($"Количество чисел больше ноля = {positivDigit}");
