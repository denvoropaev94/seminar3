/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] array = new double[5];

double[] FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-100, 100);
    }
    return arr;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

double FindMaxElement(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement)
        {
            maxElement = arr[i];
        }
    }

    return maxElement;
}

double FindMinElement(double[] arr)
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement)
        {
            minElement = arr[i];
        }
    }

    return minElement;
}
double FindDifference(double maxElement,double minElement){
    double res = maxElement - minElement;
    return res;
}

double[] result = FillArray(array);
PrintArray(result);
System.Console.WriteLine();
double maxElementResult = FindMaxElement(result);
System.Console.WriteLine($"Максимальный элемент равен : {maxElementResult} ");
double minElementResult = FindMinElement(result);
System.Console.WriteLine($"Минимальный элемент равен: {minElementResult}");
double resDif = FindDifference(maxElementResult,minElementResult);
System.Console.WriteLine($" Разница : {resDif}");