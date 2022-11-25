// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int SumDigit(int number)
{
    if(number == 0) return 0;
    return number%10+SumDigit(number/10);
}

Console.WriteLine("Введите натуральное число n:");
int n = Convert.ToInt32(Console.ReadLine());

int  sumDigit =  SumDigit(n);
Console.WriteLine($"{sumDigit}");