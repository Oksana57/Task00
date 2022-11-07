// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Countdigit (int num)
{
    int count= 0;
    while(num > 0)
    {
        num /=10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int countdigit = Countdigit(number);
Console.WriteLine($"Количество цифр чмсла {number} равно {countdigit}");