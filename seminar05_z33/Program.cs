System.Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine()); 
int[] arr = new int[] { 6, 7, 19, 345, 3 }; 
 
bool FindNumber(int N, int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] == N) 
        { 
            return true; 
        } 
    } 
    return false; 
} 

bool res = FindNumber(number, arr);
if(res==true){
    Console.WriteLine("Данное число есть в массиве");
} 
else{
    Console.WriteLine("Данного числа нет в массиве!");
}
