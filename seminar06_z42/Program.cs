//Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное

//Способ 1
/*System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string binary = Convert.ToString(number,2);
System.Console.WriteLine(binary);
*/


//Способ 2

/*System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void BinuryNumbers(int number)
{
    int i = 0;
    int a = 0;
    while (number >= 1)
    {
        a = number % 2;
        i++;

        number = number / 2;

        System.Console.Write(a);
    }
}
BinuryNumbers(number);
*/

 
//Способ 3

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


string Binury (int num)
{
    string str = string.Empty;
    //string num1 = string.Empty;

    while (num > 0)
    {
        // num1 = Convert.ToString(num%2);
        // str = $"{num1}{str}";
        str = $"{Convert.ToString(num%2)}{str}";
        num = num/2;
    }
    return str;
}

Console.WriteLine(Binury(number));