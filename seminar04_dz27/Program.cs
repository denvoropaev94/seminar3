/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();

bool isNum = int.TryParse(number, out int result);
if(isNum == false){
    Console.WriteLine("Введите число, а не символы какие-то!!! ");
    return;
}
int ReturnsSumNumbers(int num){
    int  result = 0;
   while(num>0){
        result+= num%10;
        num=num/10;
    }
    return result;
}

int res = ReturnsSumNumbers(result);
Console.WriteLine(res);