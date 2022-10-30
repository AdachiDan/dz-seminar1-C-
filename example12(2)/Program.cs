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

Console.WriteLine("Проверка: второе число кратно первому?");
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

