
int GetMaxLetterOfNumber (int number)
{
    int result = number % 10;
    int letter2 = number / 10;
    if (result < letter2)
    {
        result = letter2;
    }
    return result;
}

int RandNumber = new Random() .Next(10,99);
int result = GetMaxLetterOfNumber(RandNumber);

Console.WriteLine($"у числа {RandNumber} наибольшая цифра это {result}");