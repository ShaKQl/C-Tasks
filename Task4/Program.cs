// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:  ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (max < num2) max = num2;
if (max < num3) max = num3;

Console.WriteLine($"{num1},{num2},{num3} --> {max}");

