/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ExponentiatesNumbers(int num1,int num2){
    int res=1;
    for(int i =1; i<=num2;i++){
        res = res * num1;

    }
    return res;
}

int result = ExponentiatesNumbers(number1,number2);
Console.WriteLine(result);
