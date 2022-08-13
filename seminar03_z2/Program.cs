Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

string ShowCoordinateRange(int number){

    if (number == 1)
    {
        return "x > 0 && y > 0";
    }
     if (number == 2)
    {
        return "x < 0 && y > 0";
    }
     if (number == 3)
    {
        return "x < 0 && y < 0";
    }
     if (number == 4)
    {
        return "x > 0 && y < 0";
    }
    throw new Exception("Такой четверти не существует!");
}

string input = ShowCoordinateRange(number);
Console.WriteLine(input);