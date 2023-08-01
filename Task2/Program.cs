// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2) {
    Console.WriteLine($"Наибольшее значение: {num2} ");
}
else if (num1 == num2) {
    Console.WriteLine($"Числа равны");
}
else {
    Console.WriteLine($"Наибольшее значение: {num1} ");
}