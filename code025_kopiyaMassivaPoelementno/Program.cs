// задача 45. напишите программу, к-я будет создавать копию заданного массива с помощью поэлементного копирования

int[] array = {1, 2, 3, 4, 5};
int[] newArray = new int[array.Length];
Console.WriteLine("1st: ");
printArray(array);
Console.WriteLine("2nd: ");
newArray = Copy(array);
printArray(newArray);

int[] Copy (int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    } 
    return result;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}