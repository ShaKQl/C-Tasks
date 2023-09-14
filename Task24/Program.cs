// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int SumNumber(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumber(number);
if (number < 0)
{
    Console.WriteLine($"{number} -> не корректное чило");
}
else
{
    Console.WriteLine($"{sumNumbers} -> сумма чисел от а до {number}");
}