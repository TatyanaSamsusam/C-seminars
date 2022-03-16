Console.WriteLine("\nвведите число от 1 до 4: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine ("координаты X и Y находятся в диапазоне от 1 до бесконечности");
}
else if(number == 2)
{
    Console.WriteLine ("координаты X находятся в диапазоне от 1 до бесконечности, координаты Y находятся в диапазоне от -1 до бесконечности");
}
else if(number == 3)
{
    Console.WriteLine ("координаты X находятся в диапазоне от -1 до бесконечности, координаты Y находятся в диапазоне от -1 до бесконечности");
}
else if(number == 4)
{
    Console.WriteLine ("координаты X находятся в диапазоне от -1 до бесконечности, координаты Y находятся в диапазоне от 1 до бесконечности");
}
else
{
    Console.WriteLine("zero");
}
