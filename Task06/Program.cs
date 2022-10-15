Console.WriteLine("Введите натуральное число");
int a = Convert.ToInt32(Console.ReadLine());

if(a%2 == 0)
{
    Console.WriteLine($"Число {a} является четным");
}
else
{
    Console.WriteLine($"Число {a} неявляется четным");
}