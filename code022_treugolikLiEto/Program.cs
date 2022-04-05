// задача 40. напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// * теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других его сторон

int numberA = 25;
int numberB = 6;
int numberC = 7;

CanItBeTri(numberA, numberB, numberC); 

void CanItBeTri (int a, int b, int c)
{
    if ((a+b) > c && (a+c) > b && (b+c) > a) 
    {
        Console.WriteLine("it can be a triangle");
    }
    else
    {
        Console.WriteLine("it can NOT be a triangle");
    }
}