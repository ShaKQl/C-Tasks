// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void DivisabilityCheck(int num){
    
    if(num % 7 == 0 && num % 23 == 0){
        Console.WriteLine($" {num} -> да ");
    }
    
    else{
        Console.WriteLine($" {num} -> нет ");
    }
}

Console.WriteLine($"число -> ? ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"число -> {number} ");


DivisabilityCheck(number);
