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
// void PrintArray(int[] arr){

//     Console.WriteLine("Вывод массива:");
//     for (int i = 0;i<arr.Length;i++){
//         Console.WriteLine(arr[i]);
//     }
//   }

void FindArithmeticMeanColumns(int[,] array)
{

    int[] summ = new int[n];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ[i] += array[j, i];
        }

    }
    foreach (double elem in summ)
    {

        Console.WriteLine("Среднее арифметическое столбца с суммой " + (elem) + " равно: " + (elem / n));
    }
}

int[,] result = FillArray2D(m, n);
PrintArray2D(result);
System.Console.WriteLine();
FindArithmeticMeanColumns(result);