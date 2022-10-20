// double d = Math.Sqrt(45);
// double s = 5.099965343;
// double res = Math.Round(s, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance(int xa, int ya, int xb, int yb)
{
double d = Math.Sqrt(((xa-xb)*(xa-xb))+((ya-yb)*(ya-yb)));
return d;
}

Console.WriteLine("Введите координаты точкиc1");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки2");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

// double Distance(int xa, int ya, int xb, int yb)
// {
// double d = Math.Sqrt(((xa-xb)*(xa-xb))+((ya-yb)*(ya-yb)));
// return d;
// }

double distance =  Distance(x1, y1, x2, y2);

Console.WriteLine($"расстояние между точками А и B = {Math.Round(distance, 2, MidpointRounding.ToZero)}");