// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int Quarter(int x, int y)
{
    if(x>0 && y>0 )return 1;
    else if(x<0 && y>0 )return 2;
    else if(x<0 && y<0 )return 3;
    else if(x>0 && y<0 )return 4;
    else return 0;
}


Console.WriteLine("Введите координаты точки: ");
Console.Write("X : ");
int xCoordinates = Convert.ToInt32(Console.ReadLine());

Console.Write("Y : ");
int yCoordinates = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinates, yCoordinates);
string result = quarter > 0 ? $"Введенным координатам соовтетствует четверть: {quarter}": "Похоже ваши координаты находятся на осях или являются origin";
Console.WriteLine($"{result}");