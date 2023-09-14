
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int ToBinar(int num)
{
    int binary = 0;
    int mult = 1;
    while (num != 0)
    {
        binary += mult * (num %2);
        num = num / 2;
        mult = mult*10;
    }
    return binary;
}

Console.WriteLine(ToBinar(13));