//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
System.Console.WriteLine("Введие первое число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие второе число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();

void PrintNumbers(int index,int num){
    System.Console.Write($" {index}");
    if(index<num){

        PrintNumbers(index + 1,num);
    }

}
PrintNumbers(m,n);