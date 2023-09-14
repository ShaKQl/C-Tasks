// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[] array = new int[8];

int[] fillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int rand = new Random().Next(100, 1000);
        arr[i] = rand;
    }
    return arr;
}

int countEvens(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %2 == 0)
        {
            count++;
        }
    }
    return count;
}

fillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+ ", ");
}

Console.Write($"->> {countEvens(array)}");
