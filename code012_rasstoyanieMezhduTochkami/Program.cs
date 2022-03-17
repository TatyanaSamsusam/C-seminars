Console.WriteLine("\nвведите координаты точек A и B и я посчитаю расстояние между ними в 2D: ");
int A1 = Convert.ToInt32(Console.ReadLine());
int B1 = Convert.ToInt32(Console.ReadLine());
int A2 = Convert.ToInt32(Console.ReadLine());
int B2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((A2 - A1) ^ 2 + (B2 - B1) ^ 2);
result = Math.Round(result, 2);

Console.WriteLine(result);
