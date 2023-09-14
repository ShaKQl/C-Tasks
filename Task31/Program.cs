// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {   
        int temp = array[i];
        array[i] = array[array.Length - 1];
        array[array.Length - 1] = temp;
    }
}






