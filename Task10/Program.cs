// Задача 10: Напишите программу, которая принимает на вход трёхзначное
//  число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int SecondDigit(int number)
{
    int Lastnumber = number / 10;
    return Lastnumber % 10;
}

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(num>1000 || num <100)
{ 
    Console.WriteLine("Неправильно задано число");
}
else
{
    int secondDigit = SecondDigit(num);
    Console.WriteLine($"{secondDigit}");
}
