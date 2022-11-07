// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Sumdigit (int num)
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Sumnumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i; //sum = sum + i
    }
    return sum;
}

int sumnumbers = Sumnumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {sumnumbers}");
