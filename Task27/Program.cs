// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int number)
{
    int sum = 0;
    while(number>0)
    {
        int digit = number%10;
        number = number/10;
        sum = sum + digit;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int sumDigit = SumDigit(num);
Console.WriteLine($"{sumDigit}");