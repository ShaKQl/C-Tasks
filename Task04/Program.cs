// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Ввведите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int count = -number;

if (count < 0){
    while (count <= number){
        Console.Write($"  |{count}|  ");
        count++;
    }
}

else{
    while (count >= number){
        Console.Write($"  |{count}|  ");
        count--;
    }
}