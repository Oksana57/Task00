// 44. Ведите первые n чисел числа фибоначи 0 и 1
// если n =5 -> 01123

int[] Fibonacci(int num)
{
    int [] array = new int [num];
    // array[1] = 1;
    for(int i = 0; i < num;i++)
    {
        if(i<2) array[i] = i;
       else array[i] = array[i-1]+array[i-2];
    }
return array;
}

void PrintArray(int [] array)
{
   
    for(int i=0; i<array.Length; i++)
    {
        if(i<array.Length -1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }

 
 }
int [] arr = Fibonacci(5);
PrintArray(arr);