// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void Table(int number)
{
    if(number>0)
    {
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count,10}   {count * count, 10}");
        count++;
    }
    }
    else Console.WriteLine("некорректное число");
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num>0) Table(num);

else Console.WriteLine("некорректное число");

