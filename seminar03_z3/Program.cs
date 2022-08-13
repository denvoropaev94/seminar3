
Console.WriteLine("Введите точку х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку y2"); 
int y2 = Convert.ToInt32(Console.ReadLine());

double FindDistanse(int x1, int y1, int x2, int y2)
{
    double XY = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
    return XY;
}
double result = FindDistanse(x1, y1, x2, y2);
Console.WriteLine(result);