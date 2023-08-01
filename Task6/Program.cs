// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0){
    Console.WriteLine($"{num} --> да");
}
else {
    Console.WriteLine($"{num} --> нет");
}