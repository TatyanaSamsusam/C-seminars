/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int factorial (int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int fact = factorial(num);
System.Console.WriteLine($"факториал числа {num} равен {fact}");