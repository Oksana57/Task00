Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int count = 0;

if(N<2)
{
    Console.WriteLine("Некорректное число");
}
else
{
    while (count<N-1)
    {
        count+=2;
        Console.WriteLine($"{count}");
    }
}