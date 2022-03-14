Console.Write("\ninput a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"number is divisible by 7 and 23");
}
else
{
    Console.WriteLine($"number is NOT divisible by 7 and 23");
}

