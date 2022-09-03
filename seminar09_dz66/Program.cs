//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.WriteLine("Введие первое число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие второе число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int PrintNumbers(int m,int n){
    // System.Console.Write($" {index}");
    if(m==n) return m;
    if(m<n){

        return m + PrintNumbers(m+1, n);
    }
    throw new Exception();

}
int result = PrintNumbers(m, n);
System.Console.WriteLine(result);