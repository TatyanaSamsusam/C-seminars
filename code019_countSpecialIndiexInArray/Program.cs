// 35. Задайте одномерный массив из 123 случайных чисел. найдите кол-во элементов массива, хначения которых лежат в отрезке [10, 99]
// [5, 18, 123, 6, 2] - 1

int[] array = new int [123];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }

void printArray(int[] myarray)
{
    for (int i = 0; i < myarray.Length; i++)
    {
        Console.Write($"{myarray[i]} ");
    }
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>10 && array[i]<99) count++;
}

printArray(array);
Console.WriteLine();
Console.WriteLine(count);