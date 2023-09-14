
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

float Xintersect(int K1, int K2, int B1, int B2)
{
    float difK = K2 - K1;
    float difB = B1 - B2;
    float number =  difB / difK;
    return number;
}

double Yintersect(double numX, int K2, int B2)
{
    return K2 * numX + B2;
}

Console.WriteLine("Ввведите k1: y = _x + b");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ввведите b1: y = {k1}x + _");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"--------------------------");
Console.WriteLine($"b1: y = {k1}x + {b1}");
Console.WriteLine($"--------------------------");

Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine("Ввведите k2: y = _x + b");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ввведите b2: y = {k2}x + _");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"--------------------------");
Console.WriteLine($"b2: y = {k2}x + {b2}");
Console.WriteLine($"--------------------------");

double x = Xintersect(k1, k2, b1, b2);
double y = Yintersect(x, k2, b2);

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Точка пересечения: " + "(" + x + " , " + y + ")");