using System.Runtime.InteropServices.ComTypes;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//  |||||||||||| version - 1 ||||||||||Functions|Functions|Functions|Functions|Functions|Functions|||||||||||||||||||||||  \\

// bool DayCheck(int num)
// {
//     return num == 7 || num == 6;
// }

// bool RangeCheck(int num)
// {
//     return num >= 1 && num <= 7;
// }

// void PrintResult(int num)
// {
//     if (RangeCheck(num))
//     {
//         if (DayCheck(num))
//         {
//             Console.WriteLine($"{num} -> да");
//         }
        
//         else 
//         {
//             Console.WriteLine($"{num} -> нет");
//         }
//     }

//     else
//     {
//         Console.WriteLine($"{num} -> не является днем недели");
//     }
// }

// --------------------------------------------------------------------------------------------------------------\\
//  |||||||||||| version - 2 ||||||||||Functions|Functions|Functions|Functions|Functions|Functions|||||||||||||||||||||||  \\

string ResultAnswer(int number)
{
    string answer = "";
    
    if (number >= 1 && number <= 7)
    {
        if (number == 6 || number == 7)
        {
            answer = "да";
        }
        else
        {
            answer = "нет";
        }
    } 
    else
    {
        answer = "не является днем недели";
    }
    return answer;
}



//=================================================================================\\

Console.WriteLine("Введите день ");
int number = Convert.ToInt32(Console.ReadLine());

// PrintResult(number); ->  version1 function call

string message = ResultAnswer(number);
Console.WriteLine($"{number} -> {message} "); 

