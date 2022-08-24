//Задача 45. Напишите программу, которая будет создавать копию заданного
// двумерного массива с помощью поэлементного копирования.

Console.Write("Введите число строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int[a, b];

int[,] Fill2dArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = random.Next(10, 100);
        }

    }
    return array2d;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write($"{array2d[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] CopyArray(int[,] array)
{
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = array[i, j];
        }
    }
    return array2;

}
int[,] result = Fill2dArray(array2d);
Print2dArray(result);
System.Console.WriteLine();
int[,] res = CopyArray(result);
Print2dArray(res);
