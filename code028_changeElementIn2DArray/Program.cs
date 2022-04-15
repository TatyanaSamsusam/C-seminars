/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/


int[,] Generate2DArray(int hight, int weight)
{
    int[,] arrayA = new int[hight,weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            arrayA[i,j] = new Random().Next(1,10);
        }
    }
    return arrayA;
}
int hight = 4;
int weight = 4;
int[,] generatedArray = Generate2DArray(hight,weight);
Print2DArray(generatedArray);

for (int i = 1; i < generatedArray.GetLength(0); i+=2)
    {
        for (int j = 1; j < generatedArray.GetLength(1); j+=2)
        {
            generatedArray[i,j] *= generatedArray[i,j]; 
        }
       Console.WriteLine();
    }
Print2DArray(generatedArray);

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

