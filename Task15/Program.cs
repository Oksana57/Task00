// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool WeekEnd(int number)
{
   return number == 6 || number == 7;
}

Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7 || num < 1)  
{
    Console.WriteLine("Неправильно задано число");  
}
else
{
    bool weekEnd = WeekEnd(num);
    Console.WriteLine(weekEnd ? "Да" : "Нет");
}



      

    

