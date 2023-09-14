// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число в диапазоне 10 - 99 -> {number}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра -> {maxDigit}");

int maxDigit1 = MaxDigit(56);
Console.WriteLine($"Наибольшая цифра -> {maxDigit1}");

int maxDigit2 = MaxDigit(89);
Console.WriteLine($"Наибольшая цифра -> {maxDigit2}");

int MaxDigit(int num){
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit ;
};


