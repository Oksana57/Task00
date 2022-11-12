// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MinDigit(double[] array)
{
    int i = 0;
    double mindigit = array[i];
    while (i < array.Length)
    {

        if (array[i] < mindigit) mindigit = array[i];
        i++;
    }
    return mindigit;
}

double MaxDigit(double[] array)
{
    int i = 0;
    double maxdigit = array[i];
    while (i < array.Length)
    {
        if (array[i] > maxdigit) maxdigit = array[i];
        i++;
    }
    return maxdigit;
}


double[] arr = CreateArrayRndDouble(5, -100, 100);
PrintArray(arr);
double minDigit = MinDigit(arr);
double maxDigit = MaxDigit(arr);

void SumMinMax(double min, double max)
{
    double minDigit = MinDigit(arr);
    double maxDigit = MaxDigit(arr);
    double sum = minDigit + maxDigit;
    sum = Math.Round(sum, 1);
    Console.WriteLine($"Сумма минимального и максимального значения массива = {sum}");
}
SumMinMax(minDigit, maxDigit);
// double sumMinMax = SumMinMax(arr)
// double minDigit = MinDigit(arr);
// Console.WriteLine($"Минимальное число в массиве = {minDigit}");
// double maxDigit = MaxDigit(arr);
// Console.WriteLine($"Максимальное число в массиве = {maxDigit}");
