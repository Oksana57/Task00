// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число {num}");

int first = num / 100;
int second = num % 10;
int result = first * 10 + second;

Console.WriteLine($"Число равно {result}");

