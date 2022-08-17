int [] FillArray (int[] collection)//Метод наполнения массива
{
    for(int i=0; i< collection.Length;i++){
        collection[i] = new Random().Next(0,2);
    }
    return collection;
}

void PrintArray(int[] col)//Метод, который печает массив
{
    for(int i = 0;i<col.Length;i++)
    {
        Console.WriteLine($"{col[i]} ");
    }
}
int[] array = new int[8];

int[] n  = FillArray(array);
PrintArray(n);