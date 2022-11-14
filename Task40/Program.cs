// 40 напишите программу, которая принимет на вход три числа и проверяет может ли существовать
// треугольник со сторонами такой длинны
// каждая сторна треугольника мельше суммы двух сторон

bool Tringle(int num1, int num2, int num3)
{
    return num1<num2+num3 && num2<num1+num3 && num3<num1+num2;
}



Console.WriteLine("ВВедите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите первое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите первое число");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Tringle(a,b,c)?"Да":"Нет");