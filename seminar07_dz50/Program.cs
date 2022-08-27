// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента

Console.WriteLine("Введите количество строк");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (isNumberM == false || isNumberN == false)
{
    System.Console.WriteLine("Введены не правильные данные");
    return;
}

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
bool FindNumber(int number, int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
        if (array[i,j] == number) 
        { 
            return true; 
        } 
        }
    } 
    return false; 
} 
string FindNumberArray(int[,] array)
{
    string str = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                str = $"{Convert.ToString(i)}{","}{Convert.ToString(j)}{"|"}{str}";
            }
            

        }
    }
    return str;
}


System.Console.WriteLine();
int[,] result = FillArray2D(m, n);
PrintArray2D(result);
System.Console.WriteLine();
bool isResultNum = FindNumber(number,result);
if(isResultNum==true){
    string res = FindNumberArray(result);
    System.Console.WriteLine(res);
}
else{
    System.Console.WriteLine("Такого числа нет!");
}
