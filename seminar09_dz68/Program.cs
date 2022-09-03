//ДЗ.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

System.Console.WriteLine("Введие 1-ое число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие 2-ое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int FunkAkkerman(int m,int n)
{
      if (m == 0) {
            return n + 1;
        } 
        else if (n == 0 && m > 0) {
            return FunkAkkerman(m - 1, 1);
        } 
        else {
            return FunkAkkerman(m - 1, FunkAkkerman(m, n - 1));
        }
}

int result = FunkAkkerman(m,n);
System.Console.WriteLine(result);