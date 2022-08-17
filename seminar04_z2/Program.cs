Console.Write("Введите число: ");
string N = (Console.ReadLine());


bool isNum = int.TryParse(N, out int result);
if(isNum == false){
    Console.WriteLine("Введите число, а не символы какие-то...");
    return;
}

int GetProizvedenie(int number){
    int result = 1;
    for (int i =1;i<=number;i++){
        result = result * i;
    }
    return result;
}
int res = GetProizvedenie(result);
Console.WriteLine(res);