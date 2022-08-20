int[]array = {4,8,-8,-2};
int[] ChangeNumber(int[]arr){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}
int[] result = ChangeNumber(array);
string resultNum = string.Join("|",result);
Console.WriteLine(resultNum);