// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть в системе координат");
int num = Convert.ToInt32(Console.ReadLine());

string Quarter(int number)
{
    if (number == 1)  return "x > 0 и y > 0";
    if (number == 2)  return "x < 0 и y > 0";
    if (number == 3)  return "x < 0 и y < 0";
    if (number == 4)  return "x > 0 и y < 0";
    return null;
}

string quarter = Quarter(num);

Console.WriteLine(quarter == null 
? "Некорректный номер четверти" 
: $"Диапазон возможных координта точек в этой четверти: {quarter}");