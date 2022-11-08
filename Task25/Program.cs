// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int a, int b)
{
   int deg = a;
   for(int i=1;i<b;i++)
    {
        deg = deg*a;
    }
    return deg;
}

Console.WriteLine("Введите число А:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число натуральное B:");
int y = Convert.ToInt32(Console.ReadLine());

if(y<=0) Console.WriteLine("Введите корректное число B");
else 
{
    int degree = Degree(x, y);
    Console.WriteLine($"{degree}");
}