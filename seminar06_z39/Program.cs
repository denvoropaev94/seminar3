//Задача 39. Напишите программу, которая перевернет одномерный массив

int[] GetRandomArray(int length, int minValue, int maxValue){
    int [] array = new int[length];
    Random random = new Random();  

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue,maxValue + 1);
    }
    return array;
}

int[] array = GetRandomArray(4,1,10);

int[] result = ReverseArray(array);

PrintArray(array);
Console.WriteLine();
Console.WriteLine("Перевернутый - ");
PrintArray(result);

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}

int[] ReverseArray(int[] array){
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length-1-i];
    }
    return result;
}