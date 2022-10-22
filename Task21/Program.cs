// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
double d = Math.Sqrt(((xa-xb)*(xa-xb))+((ya-yb)*(ya-yb))+((za-zb)*(za-zb)));
return d;
}

Console.WriteLine("Введите координаты точкиc1");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки2");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance =  Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"расстояние между точками А и B = {Math.Round(distance, 2, MidpointRounding.ToZero)}");