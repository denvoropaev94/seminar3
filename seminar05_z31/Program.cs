//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

int[] array = new int[12];

int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-9, 10);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

int FindSumPositiveNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int FindSumNegativeNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}
int[] fill = FillArray(array);
PrintArray(fill);
System.Console.WriteLine();
int sumPositive = FindSumPositiveNumbers(fill);
int sumNegative = FindSumNegativeNumbers(fill);
System.Console.WriteLine($"Сумма положительных равна : {sumPositive} ");
System.Console.WriteLine($"Сумма отрицательных равна: {sumNegative} ");





