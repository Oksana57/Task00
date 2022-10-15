Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine($"{a} - максимальное число");
    Console.WriteLine($"{b} - минимальное число");
}
else
{
    Console.WriteLine($"{b} - максимальное число");
    Console.WriteLine($"{a} - минимальное число");
}