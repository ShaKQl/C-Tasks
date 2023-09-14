// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int number = new Random().Next(100, 999);
Console.WriteLine($"Введите трехзначное число -> {number}");

int twoDigit = GetNumber(number);
Console.WriteLine($"Между -> {twoDigit}");

int GetNumber(int num) {
    return ((num / 100) * 10) + (num % 10);
}