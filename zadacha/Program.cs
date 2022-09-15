string[] array = new string[3];  

  string[] FillArray(string[] arr){
  for(int i = 0;i<arr.Length;i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
                arr[i] = Console.ReadLine();
    }
    return arr;
  }
    void PrintArray(string[] col){

    Console.WriteLine("Вывод массива:");
    for (int i = 0;i<col.Length;i++){
        Console.Write($"{col[i]} ");
    }
     Console.WriteLine();
  }
string[] FindElementsArray(string[] arr){
    string[] result = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
       if(arr[i].Length<=3){
        result[i]=arr[i];
       }
    }
    return result;
}  
string[] n  = FillArray(array);
string result = string.Join(",",n);
Console.WriteLine(result);
// System.Console.WriteLine("new:");
string[] res = FindElementsArray(array);
// string resultNum = string.Join(",",res);
// System.Console.WriteLine(resultNum);
PrintArray(res);