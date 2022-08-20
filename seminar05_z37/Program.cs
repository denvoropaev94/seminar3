//Задача 37. Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и тд.
//Результат запишите в новом массиве.

int[] array = new int[10];


int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1,20);
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
int[] FindMultiplyNumbers(int[]arr){
    int[] multiplyNumbers = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        multiplyNumbers[i] = arr[i] * arr[arr.Length-1-i];

    }
    return multiplyNumbers;
}

int[] n = FillArray(array);
PrintArray(n);
Console.WriteLine();
int[] result = FindMultiplyNumbers(n);
PrintArray(result);