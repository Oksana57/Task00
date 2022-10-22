// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TableDigit (int number)
{
int index = 1;

while (index<=number)
{
    Console.WriteLine($"{index, 8}     |{index * index * index, 8}");
    index++;
}
}

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if(num>0) TableDigit(num);
else Console.WriteLine("Вы ввели некорректное число");
