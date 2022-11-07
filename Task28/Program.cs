// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Faktorial(int number)
{
    int composition = 1;
    for (int i = 1; i <= number; i++)
    {
        composition *= i; //sum = sum + i
    }
    return composition;
}

if(num>0)
{
int faktorial = Faktorial(num);
Console.WriteLine($"факториал чисел от 1 до {num} = {faktorial}");
}
else Console.WriteLine("Введено некорреконое число, требуется целое положительное число");
