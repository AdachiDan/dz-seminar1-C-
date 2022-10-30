bool check(int x, int x2)
{
    return x*x == x2 || x2*x2 == x;
}

void result(int x, int x2)
{
    
    if (check(x, x2))
    {
        Console.WriteLine("Является");
    }
    else
    {
        Console.WriteLine("Не является");
    }

}

Console.WriteLine("Проверка: является ли одно число квадратом другого?");
Console.WriteLine("Введите первое число:");

int x;

while (!int.TryParse(Console.ReadLine()!, out x)){
   Console.WriteLine("Неверный ввод");
   Console.WriteLine("Введите первое число:");
}
Console.WriteLine("Введите второе число:");

int x2;

while (!int.TryParse(Console.ReadLine()!, out x2)){
   Console.WriteLine("Неверный ввод");
   Console.WriteLine("Введите второе число:");
}
result(x, x2);
