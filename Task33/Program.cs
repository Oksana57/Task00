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

bool Digit (int[]array, int find)
{
   for(int i=0; i<array.Length; i++)
   {
    if (array[i] == find) return true;

}
return false;
}

 int [] arr = CreteArrayRndInt(5, 0, 509);
 PrintArray(arr);

 Console.WriteLine("Введите искомый элемент: ");
 int num = Convert.ToInt32(Console.ReadLine());

 bool digit = Digit(arr, num);
 Console.WriteLine($"{digit}");
