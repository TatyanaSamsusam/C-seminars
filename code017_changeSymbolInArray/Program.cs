// 32. напишите программу замены элементов массива: положительные замените на отрицательные, и наоборот
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray (int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int i=0; i<length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation+1);
    }
    return arrayOfNumbers;
}

void printArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]} ");
    }
}

int[] negativeArray (int [] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] *=-1;
    }
    return myArray;
}

int[] myArray = GetArray(4,3);
printArray(myArray);

Console.WriteLine();
int[] negArray = negativeArray(myArray);
printArray(negArray);