Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int CheckNumbers(int number){

   int count = 0;
   while (n>0){
    n = n/10;
    count++;
   }
   return count;
}
int display = CheckNumbers(n);
Console.WriteLine(display);