/*Задача 47. Задача по заполнению двумерного массива случайными числами
Заполняет двумерный массив случайными числами
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    System.Console.WriteLine("Введены не правильные данные");
    return;
}

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m,n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = random.Next(10,1001);
        }
    }
    return  array;
}

void PrintArray2D(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] result = FillArray2D(m,n);
PrintArray2D(result);
*/

/*Задача 48. Задаем двумерный массив размером m на n. Каждый элемент массива находим по формуле m+n

void PrintArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            array[i, j] = i+j;
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] array = new int[5, 5];
PrintArray(array);
*/

/*Задача 49. Задаем двумерный массив случ числами. Находим элементы, у которых оба индексы четные.
Заменяем эти элементы на квадраты
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    System.Console.WriteLine("Введены не правильные данные");
    return;
}

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m,n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = random.Next(10,100);
        }
    }
    return  array;
}

void PrintArray2D(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FindEvenIndices(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if((i%2 == 0)&&(j%2==0)){
                array[i,j] = array[i,j]*array[i,j];
            }
        }
    }
    return array;
}

int[,] result = FillArray2D(m,n);
PrintArray2D(result);
System.Console.WriteLine();
int[,] res = FindEvenIndices(result);
PrintArray2D(res);
*/


//50 Задаем двумерный массив. Находим суммы элементов, находящихся на главной диагонали.
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
            array[i, j] = random.Next(10, 100);
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

int FindSumDiagonalIndices(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i == j))
            {
                sum += array[i, j];
            }
        }
    }
    return sum;
}

int[,] result = FillArray2D(m, n);
PrintArray2D(result);
System.Console.WriteLine();
int res = FindSumDiagonalIndices(result);
System.Console.WriteLine(res);