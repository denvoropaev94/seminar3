//Задача 55. Заменяем строки на столбцы
Console.WriteLine("Введите количество строк");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    System.Console.WriteLine("Введены не правильные данные");
    return;
}

int[,] FillArray2D(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = random.Next(1,10);
        }
        Console.WriteLine();
    }
    return newArray;
}

int[,] result = FillArray2D(m,n);

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

int[,] SwapRowToColumns (int[,] arr)
{
    int[,] tempArr = new int [arr.GetLength(0), arr.GetLength(1)];
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        Console.WriteLine("Это не возможно!");
        throw new Exception();
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempArr[j,i] = arr[i,j];
        }
    }
    return tempArr;
}

PrintArray2D(result);
Console.WriteLine();
PrintArray2D(SwapRowToColumns(result));