Console.WriteLine("\ninput X and Y: ");
int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine ("the first quarter");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine ("the second quarter");
}
else if(X > 0 && Y < 0)
{
    Console.WriteLine ("the fourth quarter");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine ("the third quarter");
}
else
{
    Console.WriteLine("zero");
}