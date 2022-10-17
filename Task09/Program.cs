

// int firstDigit = num / 10;
// int secondDigit = num % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// int max = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {num} = {max}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} = {result}");

// Console.Write($"Наибольшая цифра числа {num} = ");
// Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число  из диапазона 10 - 99 -> {num}");

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");