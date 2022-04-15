/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

int[,] GenerateArray (int hight, int length)
{
    int[,] generatedArray = new int[hight, length];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            generatedArray[i,j] = new Random().Next(1, 10);
        }
    }
    return generatedArray;
}

void PrintArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i,j]}\t");
        }
       Console.WriteLine();
    }
}

int countMainDiagonal (int[,] generatedArray)
{
    int sum = 0;
    int length = (generatedArray.GetLength(0) > generatedArray.GetLength(1)) ? generatedArray.GetLength(1) : generatedArray.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        sum += generatedArray[i,i];
    }
    return sum;
}

int hight = 3; int length = 4;
int[,] generatedArray = GenerateArray(hight, length);
PrintArray(generatedArray);
int sum = countMainDiagonal(generatedArray);
System.Console.WriteLine($"sum is equal to {sum}");