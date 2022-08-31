//Задача поменять первую и последнюю строку
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
int[,] result = FillArray2D(m,n);
PrintArray2D(result);

int[] GetFirstRow(int[,]array){
    int[] firstRow = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        firstRow[i] = array[0,i];   
    }
    return firstRow;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]} ");
}
}
int[] GetLastRow(int[,]array){
    int[] lastRow = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        lastRow[i] = array[array.GetLength(1)-1,i];   
    }
    return lastRow;
}
void ResultPrintArray(int [,] array)
{
    for (int i = 1; i < array.GetLength(1)-1; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

int[] resultFirstRow = GetFirstRow(result);
int[] resultLastRow = GetLastRow(result);
PrintArray(resultLastRow);
System.Console.WriteLine();
ResultPrintArray(result);
PrintArray(resultFirstRow);