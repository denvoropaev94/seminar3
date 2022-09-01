﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine($"\nВведите размер массива X x Y x Z:");
Console.WriteLine("Введите X: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("Введите Y: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int y);
Console.WriteLine("Введите Z:  ");
bool isNumberZ = int.TryParse(Console.ReadLine(), out int z);

if (isNumberM == false || isNumberN == false || isNumberZ == false)
{
    System.Console.WriteLine("Введены не правильные данные");
    return;
}

int[,,] FillArray3D(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random random = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = random.Next(10,100);
            }
            
        }
    }
    return array;
}
void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
               Console.Write( $"X({i}) Y({j}) Z({k})={array[i,j,k]}; "); 
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
void CreateArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
int[,,] result = FillArray3D(x, y, z);
CreateArray(result);
PrintArray3D(result);