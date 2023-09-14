
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
ThreeDigit(num);

// ||||||||||||||||||||||||Functions|Functions|Functions|Functions|Functions|Functions||||||||||||||||||||||||| \\

bool CheckDigit(int digit){
    return digit / 1000 == 0 && digit / 100 != 0;
}

bool CheckForTwo(int digit)
{
    return !CheckDigit(digit) && digit < 100;
}

bool CheckForMore(int digit)
{
    return !CheckDigit(digit) && digit > 999;
}

int LastDigit(int digit)
{
    if (CheckDigit(digit))
    {
        digit = digit % 10;
        Console.WriteLine($"Третье значение числа {num} -> {digit}");
    }
    return digit;
}

void ThreeDigit(int number)
{
    LastDigit(number);

    if(!CheckDigit(number))
    {
        while (CheckForMore(number)|| CheckForTwo(number))
        {
            if (CheckForTwo(number))
            {
                Console.WriteLine($"{num} -> Третьего числа нет");
                break;
            }
            number /= 10;
        }
        LastDigit(number);
    }
}


