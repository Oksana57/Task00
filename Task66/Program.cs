// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbersTwo(int num1, int num2)
{
    return num2 == num1 ? num1 : num2+SumNaturalNumbersTwo(num1, num2-1);
}

Console.WriteLine("Введите натуральное число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n:");
int n = Convert.ToInt32(Console.ReadLine());

if(m<n)
{
int sumNaturalNumbersTwo = SumNaturalNumbersTwo(m, n);
Console.WriteLine($"{sumNaturalNumbersTwo}");
}
else 
{
int sumNaturalNumbersTwo = SumNaturalNumbersTwo(n, m);
Console.WriteLine($"{sumNaturalNumbersTwo}");
}