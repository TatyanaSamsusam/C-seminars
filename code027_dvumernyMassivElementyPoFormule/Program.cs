// задача 48. задайте двумерный массив размером m на n, каждый элемент в массиве находится по формуле: Amn = m + n.
// выведите полученный массив на экран
// m = 3, n =4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int m = 3;
int n = 4;

int[,] array1 = new int[m,n];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i,j] = i +j;
    }
}

void Print2DArray(int[,] arrayToPrint)
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

Print2DArray(array1);