// Задача 43: Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//  задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double CalculationX(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2); return x;
    // double y = k2*((b2-b1)/(k1-k2))+b2; return y;
}

double CalculationY(double k1, double k2, double b1, double b2)
{
    double y = k2 * ((b2 - b1) / (k1 - k2)) + b2; return y;
}

void CrossLine(double CalculationX, double CalculationY)
{
    Console.WriteLine($"Координаты точки пересечения прямых ({CalculationX},{CalculationY})");
}

Console.WriteLine("Введите коэффициент k1");
double k1 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
double k2 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
double b1 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = Convert.ToUInt32(Console.ReadLine());

if (k1 == k2 || b1 == b2) Console.WriteLine("Прямые не пересекаются");
else
{
    double calculationX = CalculationX(k1, k2, b1, b2);
    double calculationY = CalculationY(k1, k2, b1, b2);
    CrossLine(calculationX, calculationY);
}

