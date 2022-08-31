// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    System.Console.WriteLine("Введены не правильные данные");
    return;
}
int[,] result = FillArray2D(m, n);
PrintArray2D(result);
Console.WriteLine();
SumLineElements(result);

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
void SumLineElements(int[,] array)
{
    int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Sum2 = 0;
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Sum2 += array[i, j]; } //Сумма всех членов 1ой строки.
        if (Sum2 < Sum1)
        { Sum = Sum2; Row = i; }
        Sum1 = Sum2;
    }

    Console.WriteLine($"Наименьшаяя сумма = {Sum} ");
    Console.WriteLine($"Номер строки = {Row}");

}


