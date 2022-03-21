/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
void CreateArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    Console.Write("[");

    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if (i < length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int[] arr = new int[8];
CreateArray(arr);
PrintArray(arr);
