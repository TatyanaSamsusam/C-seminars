/* задача 46. задайте двумерный массив размером m*n, заполненный случайными целыми числами
m = 3, n = 4
1 4 8 9
5 -2 33 -2
77 3 8 1*/

int[,] Generate2DArray(int hight, int weight, int delta)
{
    int[,] _return = new int[hight,weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            _return[i,j] = new Random().Next(delta*-1, delta);
        }
    }
    return _return;
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

Console.WriteLine("input m");
int hight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input n");
int weight = Convert.ToInt32(Console.ReadLine());

int[,] generatedArray = Generate2DArray(hight,weight,50);
Print2DArray(generatedArray);