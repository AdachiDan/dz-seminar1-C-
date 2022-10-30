
Console.WriteLine("Проверка: второе число кратно первому?");
Console.WriteLine("Введите первое число:");
string inputString = Console.ReadLine()!;
int x = int.Parse(inputString);

Console.WriteLine("Введите второе число:");
string inputString2 = Console.ReadLine()!;
int x2 = int.Parse(inputString2);

void result(int x, int x2)
{

    int x3 = x % x2;

    if (x3 == 0)
    {
        Console.WriteLine("Число " + x + " кратно " + x2);
    }
    else
    {
        Console.WriteLine("Число " + x + " некратно " + x2 + " остаток " + x3);
    }

}

result(x, x2);
