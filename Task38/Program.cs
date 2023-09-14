// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

float[] array = new float[5];

float[] fillArray(float[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        float rand = new Random().Next(0, 100);
        arr[i] = rand;
    }
    return arr;
}

float sumOnOdds(float[] arr)
{
    float sum = 0;
    float min = arr[0];
    float max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] < min)
        {
            min = arr[i];
        }

        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    sum = max - min;
    return sum;
}

fillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}

Console.Write($"->> {sumOnOdds(array)}");
