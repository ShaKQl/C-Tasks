// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

bool CheckIfMultiple(int num, int num1){
    return num * num == num1 || num1 * num1 == num;
}

Console.WriteLine($"число1 -> ? ");
int numeber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"число2 -> ? ");
int numeber2 = Convert.ToInt32(Console.ReadLine());

bool checkIf = CheckIfMultiple(numeber1, numeber2);

Console.WriteLine(checkIf? $"{numeber1}, {numeber2}" + " -> да" : $"{numeber1}, {numeber2}" + " -> нет");