// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int DegreeDigit(int num1, int num2)
{
    if(num2==0) return 1;
    return num1*DegreeDigit(num1, num2-1);
}



Console.WriteLine("Введите натуральное число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n:");
int n = Convert.ToInt32(Console.ReadLine());

if(n>=0) 
{
int degree = DegreeDigit(m,n);
Console.WriteLine($"{degree}");
}
else Console.WriteLine("Введите корректную степень число");

// int Pow(int numA, int numB)
// {
//     return numB == 0 ? 1 : numA * Pow(numA, numB - 1);
// }