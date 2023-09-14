// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int[] fillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{i + 1} Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int countPositives(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+"  ");
    }

    Console.Write("] ");
}


Console.WriteLine("Сколько чисел желаете ввести?");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

fillArray(array);
Console.WriteLine(" ");
PrintArray(array);
Console.Write($" ->> {countPositives(array)}");
