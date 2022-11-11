double Degree(int a, int b)
{
   double resdeg = 1;
   double res = 0;
   for(int i=1;i<=b;i++)
    {
         resdeg = resdeg*a;
    }
    if (b>0) res = resdeg;
    else res = 1/resdeg;
        // else res = resdeg;
    
    return res;
}

Console.WriteLine("Введите число А:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int y = Convert.ToInt32(Console.ReadLine());


    double degree = Degree(x, y);
    Console.WriteLine($"{degree}");

