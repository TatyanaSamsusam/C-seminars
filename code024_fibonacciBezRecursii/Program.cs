// не используя рекурсию, выведите первые N чисел Фибоначчи. первые два числа Фибоначчи: 0 и 1
// если N = 5, то 0 1 1 2 3
// если N = 3, то 0 1 1
// если N = 7, то 0 1 1 2 3 5 8 

int n = 7;

int[] fib (int n)
{
    int[] result = new int [n];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < n; i++)
    {
        result[i] = result[i-1] + result[i-2];
    }
    return result;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
printArray(fib(n));