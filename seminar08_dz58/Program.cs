Console.WriteLine("Введите количество строк 1-ой матрицы");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов 1-ой и строк 2-ой матрицы");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите количество столбцов 2-ой матрицы");
bool isNumberP = int.TryParse(Console.ReadLine(), out int p);

if (isNumberM == false || isNumberN == false || isNumberP == false)
{
    System.Console.WriteLine("Введены не правильные данные");
    return;
}

Console.WriteLine($"\nПервая матрица:");
int[,] firstMartrix = FillArray2D(m, n);
PrintArray2D(firstMartrix);


Console.WriteLine($"\nВторая матрица:");
int[,] secomdMartrix = FillArray2D(n, p);
PrintArray2D(secomdMartrix);

Console.WriteLine($"\nПроизведение первой и второй матриц:");
int[,] resultMatrix = FillArray2D(m, p);
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);

PrintArray2D(resultMatrix);

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}