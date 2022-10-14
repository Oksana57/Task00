Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());

if(a<1) 
Console.WriteLine("Вы ввели недопустимое число");

else
{
    int count = -a;
    while (count<=a)
    {
    Console.WriteLine($"{count}");
    count ++;
    }

}