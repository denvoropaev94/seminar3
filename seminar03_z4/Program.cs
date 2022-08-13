Console.WriteLine("Введите число");
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