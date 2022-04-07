// задача 42. напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 - 101101, 3 - 11, 2 - 10

int number = 3;
Console.WriteLine($"количество знаков {CountDigits(number)}");
int count = CountDigits(number);
printArray(convert(number, count));

int CountDigits (int number)
{
    double count = 0;
    int result = 1;
    while (count < number)
    {
        count = Math.Pow(2, result);
        result ++;
    }
    return result;
}

int[] convert (int number, int CountDigits)
{
    int[] array = new int[CountDigits];
    for (int i = 0; i < CountDigits; i++)
    {
        array[CountDigits -i -1] = number % 2;
        number/=2;
    }
    return array;
}


void printArray (int[] array)
{
    if (array[0] != 0)
    {
        Console.WriteLine(array[0]);
    }
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}