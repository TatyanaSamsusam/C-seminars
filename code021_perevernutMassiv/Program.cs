/* задача 39. напишите программу, которая перевернет одномерный массив.
[1 2 3 4 5] -> [5 4 3 2 1]*/

int[] GenerateArray(int length, int MaxValue)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(0, MaxValue + 1);
    }
    return returningArray;
}

int[] rotateArray(int[] inputArray)
{
    int[] returningArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        returningArray[i] = inputArray[inputArray.Length - i - 1];
    }
    return returningArray;
}

void printArray(int[] inputArray)
{   Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i]);
        if (i != inputArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int[] arrayToRotate = GenerateArray(10, 10);
int[] rotatedArray = rotateArray(arrayToRotate);
int[] rotatedRotatedArray = rotateArray(rotatedArray);

Console.WriteLine("Сгенерированный массив");
printArray(arrayToRotate);
Console.WriteLine("Перевернутый массив");
printArray(arrayToRotate);
Console.WriteLine("Перевернутый еще раз массив");
printArray(rotatedRotatedArray);