// задайте массив. напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; [6, 7, 19, 345, 3] -> нет
// 3; [6, 7, 19, 345, 3] -> да

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

int[] myArray = GetArray(5,2);
printArray(myArray);

int find = 2;
int index = 0;

for (index = 0; index < myArray.Length; index++)
{
    if(myArray[index] == find)
    {
        Console.WriteLine("yes");
        break;
    }
    else 
    {
        Console.WriteLine("no");
        break;
    }
}
