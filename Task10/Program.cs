// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

bool CheckDigits(int number)
{
    return number >= 100 && number <= 999;
}

int MiddleNumber(int number)
{
    int result = -1;
    if (CheckDigits(number))
    {
        result = (((number % 100) - (number % 10)) / 10);
    }
    else
    {
        Console.WriteLine("Введите трехзначное число");
    }
    return result;
}

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int result = MiddleNumber(num);
Console.WriteLine($"Middle числа {num} -> {result}");

