Console.WriteLine("Введите х координату");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату");
int y = Convert.ToInt32(Console.ReadLine());

int result = FindNumberQuater(x,y);
Console.WriteLine(result);

int FindNumberQuater(int x, int y){

    if(x>0 && y>0)
    {
        return 1;
    }

    if(x<0 && y>0){
        return 2;
    }

    if(x<0 && y<0){
        return 3;
    }

    if(x>0 && y<0){
        return 4;
    }
   throw new Exception("Ввели неправильные данные");
}



/*

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
double result = FindDistanse(3,6,2,1);//переделать
Console.WriteLine(result);
*/

/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string PrintsТumbersSquares(int num)
{
string result = "";
    for (int i = 1; i <= num; i++)
    {
        result += Math.Pow(i,2);
    }
    return result;
}
string result = PrintsТumbersSquares(num);
Console.WriteLine(result);
*/