// задайте массив из 12 элементов, заполненный случайными числами в промежутке от -9 до 9. найдите сумму отр и полож элем массива

int[] GetArrayOfNumbers (int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int i=0; i<length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation+1);
    }
    return arrayOfNumbers;
}

int GetPositiveSum (int[] arrayOfNumbers)
{
    int positiveSum = 0;
    for(int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] > 0)
        {
            positiveSum += arrayOfNumbers[i];
        }
    }
    return positiveSum;
}

int GetNegativeSum (int[] arrayOfNumbers)
{
    int negativeSum = 0;
    for(int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] < 0)
        {
            negativeSum += arrayOfNumbers[i];
        }
    }
    return negativeSum;
}
void printArray(int[] arrayOfNumbers)
{
    Console.Write ("[");
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        Console.Write(arrayOfNumbers[i]);
        if (i != arrayOfNumbers.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.Write ("]");
}
int[] arrayOfNumbers = GetArrayOfNumbers(12,9);
int positiveSum = GetPositiveSum(arrayOfNumbers);
int negativeSum = GetNegativeSum(arrayOfNumbers);
Console.Write("В массиве ");
printArray(arrayOfNumbers);
Console.WriteLine($" сумма положительных чисел равна {positiveSum}, сумма отрицательных чисел равна {negativeSum}");
