// 42. Напишите программу которая будет преобразовавать десятичное число 
// в двоичное
// 45-> 101101

string Converter(int num)
{
   string res = "";
   while(num!=0)
{
    res = $"{(num%2)}{res}";
    num/=2;
}
   return res;
}

Console.WriteLine("ВВедите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в десятичной системе равно {Converter(a)}");
// Console.WriteLine()