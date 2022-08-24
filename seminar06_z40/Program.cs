// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
//треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону ");
int C = Convert.ToInt32(Console.ReadLine());

bool FindTeorema(int A, int B, int C)
{
  bool result = (A < B + C)&&(B < A + C)&&(C < B + A);
  return result;
    }

bool result = FindTeorema(A, B, C);
if(result == true)
{
    Console.WriteLine("Такой треугольник может существовать! ");
}
else{
    Console.WriteLine("Такой треугольник не может существовать! ");
}