//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] FillNewArray(int num)
// {
//     int j = 0;
//     int[] array = new int[num / 2];
//     for (int i = 1; i <= num; i++)
//     {
//         if (i % 2 == 0)
//         {
//             array[j] = i;
//             j++;
//         }
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }

// int[] result = FillNewArray(number);
// PrintArray(result);

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

List<int> FillNewArray(int num)
{
    List<int> list = new List<int>();
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            list.Add(i);
        }
    }
    return list;
}

void PrintArray(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        System.Console.Write($"{list[i]} ");
    }
}

List<int> list = FillNewArray(number);
PrintArray(list);