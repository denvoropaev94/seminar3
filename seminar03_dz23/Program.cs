Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

int[] TableOfCubes(int s)
{
    int[] array = new int[s];
    for (int i = 1; i <= N; i++)
    {
        array[i - 1] = i * i * i;
    }
    return array;
}
int[] result = TableOfCubes(N);
for (int i = 0; i < result.Length; i++){
    Console.WriteLine(result[i]);
}
