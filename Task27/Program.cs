
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Console.WriteLine("Число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int number)
{
    int result = 0;

    for (int i = 0; number/10 != 0; i++)
    {
        result += number % 10;
        number /= 10;
    }

    result += number;
    return result;
}

int finalResult = SumOfDigits(num);
Console.WriteLine($"{finalResult} --> Сумма цифр в числе {num} ");