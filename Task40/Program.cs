using System;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Сторона1:");
int side1 = Convert.ToDouble( Console.ReadLine()); 

Console.WriteLine("Сторона2:"); 
int side2 = Convert.ToDouble( Console.ReadLine()); 

Console.WriteLine("Сторона3:"); 
int side3 = Convert.ToDouble( Console.ReadLine()); 

bool CheckTriagnle(int check1, int check2, int check3)
{
    if(check1 + check2 >= check3 
    && check1 + check3 >= check2 
    && check3 + check2 >= check1)return true;

    else return false;
}

bool result = CheckTriagnle(side1, side2, side3);
Console.WriteLine($"{result}"); 
