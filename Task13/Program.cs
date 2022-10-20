// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int number)
{
    while (number >= 1000)
    {
       number = number / 10;
    }
    return number % 10;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

num = Math.Abs(num);
if(num<100)
{ 
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int thirdDigit = ThirdDigit(num);
    Console.WriteLine($"{thirdDigit}");
}