/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

//Console.Write("Введите количество элементов массива: \t ");
//int elementsCount = int.Parse(Console.ReadLine());
int[] array = new int[8];

  int[] FillArray(int[] arr){
  for(int i = 0;i<arr.Length;i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
                arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
  }
    void PrintArray(int[] col){

    Console.WriteLine("Вывод массива:");
    for (int i = 0;i<col.Length;i++){
        Console.WriteLine(col[i]);
    }
  }
int[] n  = FillArray(array);
PrintArray(n);
      