// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int number)
{
    if (number < 10000 || number > 99999) Console.WriteLine("Вы ввели некорректное число");
    else
    {
        int number1 = number / 10000;
        int number5 = number % 10;
        int number2 = number / 1000 % 10;
        int number4 = number / 10 % 10;

        if (number1 == number5 && number2 == number4)
        {
            Console.WriteLine("Да");
        }
        else Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите пятизнаяное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

Palindrome(num);

