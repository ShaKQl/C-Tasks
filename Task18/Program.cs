// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


string Quarter(int x)
{
    if(x == 1 )return "Domain: x > 0, Range: y > 0";
    if(x == 2 )return "Domain: x < 0, Range: y > 0";
    if(x == 3 )return "Domain: x < 0, Range: y < 0";
    if(x == 4 )return "Domain: x > 0, Range: y < 0";
    return null;
}

Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Quarter(quarter)}");

