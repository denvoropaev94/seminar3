//Задача 35. Задайте одномерный массив случайными числами.
// Найдите количество элементов массива, значения которыз лежат в отрезке[10,99]


int[] array = new int[10];


int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(10,200);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int FindCountNumbers(int[]arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>= 10 && arr[i]<=99){
            count++;
    }
    }
    return count;
}
int[] n = FillArray(array);
PrintArray(n);
Console.WriteLine();
int result = FindCountNumbers(n);
Console.WriteLine(result); 