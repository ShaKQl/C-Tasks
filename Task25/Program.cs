// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Console.WriteLine("Number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Power: ");
int pwr = Convert.ToInt32(Console.ReadLine());

int PowerOf(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *=  number;
    }
    return result;
}

int finalResult = PowerOf(num, pwr);
Console.WriteLine($"{finalResult} --> Число {num} в {pwr}ой степени ");