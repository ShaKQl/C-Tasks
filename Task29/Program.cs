


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Условие задания была слишком расплывчатой и понял  я его как -> 
// Массив задаётся с максимальным количестовм элементов (8), где каждое значение присваивает пользоватьель
// Если массив достигает максимального значения то выводится весь массив, иначе все значения введённые пользователем ->
// как в примере:    // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
                    // 6, 1, 33 -> [6, 1, 33] 
// Технически, то что сделал я, сложнее, надеюсь оцените)
                    



int[] array = new int[8]; // Задал массив

void OutOfArray(int[] arr, string el, int boundary, int n) 
{
    bool found = el == "stop";
    if (found)
    {
        Console.WriteLine();
        Console.Write("--------------------------------");
        Console.WriteLine();
        for (int j = 0; j < boundary; j++)
        {
            Console.Write(j == boundary - 1 ? $"{arr[j]}" : $"{arr[j]},");
        }
    }
    else
    {
        arr[n] = Convert.ToInt32(el);
    }
}

void FillArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число или 'stop' [{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]}]: ");
        
        var arg = Convert.ToString(Console.ReadLine());
        

        OutOfArray(arr, arg, count, i);
        if (arg == "stop")
        {
            break;
        }
        
        else if (i == 7)
        {
            Console.WriteLine();
            Console.Write("--------------------------------");
            Console.WriteLine();
            for (int j = 0; j < count + 1; j++)
            {
                Console.Write(j == count  ? $"{arr[j]}" : $"{arr[j]},");
            }

        }
        count++;
    }
}

FillArray(array);
