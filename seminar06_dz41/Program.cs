// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество цифр: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] array = new int[elementsCount];

  int[] FillArray(int[] arr){
  for(int i = 0;i<arr.Length;i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
                arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
  }
    void PrintArray(int[] arr){

    Console.WriteLine("Вывод массива:");
    for (int i = 0;i<arr.Length;i++){
        Console.Write(arr[i]);
    }
  }

  int CountPozitiveElements(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0){
            count++;
        }
    }
    return count;
  }
int[] result  = FillArray(array);
string resultNum = string.Join(",",result);
System.Console.WriteLine(resultNum);
int countResult = CountPozitiveElements(result);
System.Console.WriteLine($"Количество положительных чисел равно : {countResult} ");