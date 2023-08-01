// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Выберете число:");

int number = Convert.ToInt32(Console.ReadLine());
int start = 0;

Console.Write($"{number} --> ");

while (start + 1 < number){
    start += 2;
    Console.Write($" {start},");
};