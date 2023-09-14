// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void DivisabilityCheck(int num1, int num2){
    int remainder = num1 % num2;
    
    if(remainder == 0){
        Console.WriteLine($" {num1}, {num2} -> Кратно ");
    }
    else{
        Console.WriteLine($" {num1}, {num2} -> не кратно, остаток {remainder} ");
    }
}

Console.WriteLine($"Первое число -> ? ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число -> {number1} ");

Console.WriteLine($"Делимое -> ? ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Делимое -> {number2} ");

DivisabilityCheck(number1, number2);
