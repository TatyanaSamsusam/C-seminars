int number = new int();
System.Console.WriteLine("input a number from 100 till 999");
number = Convert.ToInt32(Console.ReadLine());

number = number / 10;
int result = number % 10;

Console.WriteLine($"вторая цифра это {result}");