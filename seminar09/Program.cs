// System.Console.WriteLine("Введие число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// void PrintNumbers(int num,int index=1){
//     System.Console.Write($" {index}");
//     if(index<num){
//         PrintNumbers(num,index +1);
//     }
// }
// PrintNumbers(number);


//2
// System.Console.WriteLine("Введие первое число");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введие второе число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// void PrintNumbers(int index,int num){
//     System.Console.Write($" {index}");
//     if(index<num){

//         PrintNumbers(index + 1,num);
//     }

// }
// PrintNumbers(m,n);

// Найти сумму цифр в числе с помощью рекурсии.
// System.Console.WriteLine("Введие число");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     int sum = 0;
//     if (num > 0)
//     {
//         return sum = num % 10 + SumNumbers(num / 10);
//     }
//     else
//     {
//         return sum;
//     }
// }
// int result = SumNumbers(number);
// System.Console.WriteLine(result);

//4

// int Pow(int a, int b)
// {
//     if (b == 0) return 1;
//     if (b == 1) return a;
//     if (b > 0)
//     {
//         return a * Pow(a, b - 1);
//     }
//     throw new Exception();
// }
// int result = Pow(2, 3);
// System.Console.WriteLine(result);


//ДЗ.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// System.Console.WriteLine("Введие 1-ое число");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введие 2-ое число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// int FunkAkkerman(int m,int n)
// {
//       if (m == 0) {
//             return n + 1;
//         } 
//         else if (n == 0 && m > 0) {
//             return FunkAkkerman(m - 1, 1);
//         } 
//         else {
//             return FunkAkkerman(m - 1, FunkAkkerman(m, n - 1));
//         }
// }

// int result = FunkAkkerman(m,n);
// System.Console.WriteLine(result);


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

