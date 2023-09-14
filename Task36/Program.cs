// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int[] array = new int[5];

int[] fillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int rand = new Random().Next(-100, 100);
        arr[i] = rand;
    }
    return arr;
}

int sumOnOdds(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2 == 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

fillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+ ", ");
}

Console.Write($"->> {sumOnOdds(array)}");
