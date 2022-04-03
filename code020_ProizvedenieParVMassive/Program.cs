// найдите произведение пар чисел в одномерном массиве. парой считаем первый и последний элемент, второй и предпоследний, и т.д. Результат запишите в отдельный массив

int[] GetInitialArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-200, 200);
    }
    return array;
}

void printInitialArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]} ");
    }
    Console.WriteLine();
}

int[] getFinalArray (int[] array)
{
    int length = (int)Math.Ceiling(array.Length/2.0);
    int[] multiArray = new int [length];
    for (int i = 0; i < length; i++)
    {
        if (i == array.Length-1-i)
        {
            multiArray[i] = array[i];
        }
        else
        {
            multiArray[i] = array[i] * array[array.Length -1 - i];
        }
    }
    return multiArray;
}

int[] arr = {1,5,6,9,8};
int[] res = getFinalArray(arr);
printInitialArray(res);