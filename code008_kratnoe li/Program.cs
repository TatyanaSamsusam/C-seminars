
Console.Write("input a number A");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("input a number B");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine($"number A is divisible by number B");
}
else
{
    Console.WriteLine($"number A is not divisible by number B, remainder is {a % b}");
}
